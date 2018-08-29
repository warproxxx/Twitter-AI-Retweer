import tweepy
from tweepy import OAuthHandler

import pandas as pd

import os

screen_name = ''

cache = os.getenv('APPDATA') + "\\tweets.csv"

consumer_key = ''
consumer_secret = ''
access_token = ''
access_secret = ''

auth = OAuthHandler(consumer_key, consumer_secret)
auth.set_access_token(access_token, access_secret)

api = tweepy.API(auth)

if os.path.isfile(cache):
    df = pd.read_csv(cache, header=None)
    alltweets = []
    new_tweets = api.user_timeline(screen_name,since_id =df[0][0])
    alltweets.extend(new_tweets)

    outtweets = [[tweet.id_str, tweet.created_at, tweet.text.encode("utf-8")] for tweet in alltweets]
    new = pd.DataFrame(outtweets)
    df = pd.concat([new,df]).reset_index(drop=True)
else:
    alltweets = []
    new_tweets = api.user_timeline(screen_name,count=200)
    alltweets.extend(new_tweets)
    oldest = alltweets[-1].id - 1

    while len(new_tweets) > 0:
            new_tweets = api.user_timeline(screen_name,count=200,max_id=oldest)
            alltweets.extend(new_tweets)
            oldest = alltweets[-1].id - 1

    outtweets = [[tweet.id_str, tweet.created_at, tweet.text.encode("utf-8")] for tweet in alltweets]
    df = pd.DataFrame(outtweets)

df.to_csv(cache, header=False, index=False)
