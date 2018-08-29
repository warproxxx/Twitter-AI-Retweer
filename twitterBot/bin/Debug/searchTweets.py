import argparse, sys
import tweepy
from tweepy import OAuthHandler
from datetime import datetime, timedelta

import pandas as pd

import os

parser=argparse.ArgumentParser()

parser.add_argument('--keywords', help='Comma Seperated list of keywords')

parser.add_argument('--consumerkey', help='Twitter API Consumer Key')
parser.add_argument('--consumersecret', help='Twitter API Consumer Key')
parser.add_argument('--accesstoken', help='Twitter API Access Token')
parser.add_argument('--accesssecret', help='Twitter API Access Secret')

parser.add_argument('--location', help='1 or 0')
parser.add_argument('--city', help='City')
parser.add_argument('--country', help='Country')
parser.add_argument('--radius', help='The Radius')

parser.add_argument('--timeframe', help='alltime or 1hour or 3hour or 24hour')

parser.add_argument('--resultcount', help='Total Results')

parser.add_argument('--relevency', help='All or High or Medium or Low')

args=parser.parse_args()

keyword = args.keywords

if (args.location == '1'):
    keyword = keyword + ' geocode:"' + args.city + "," + args.country + '",' + args.radius + "mi"  

if (args.timeframe != 'all'):
    start_date = ''
    end_date = datetime.today().strftime('%Y-%m-%d')

    if (args.timeframe == '1day'):
        start_date = (datetime.today() - timedelta(days=1)).strftime('%Y-%m-%d')
    elif (args.timeframe == '2day'):
        start_date = (datetime.today() - timedelta(days=2)).strftime('%Y-%m-%d')
    elif (args.timeframe == '7day'):
        start_date = (datetime.today() - timedelta(days=7)).strftime('%Y-%m-%d')

    keyword = keyword + " since:" + start_date + " until:" + end_date

f = open("keyword.txt","w+")
f.write(keyword)
f.close()
    
consumer_key = args.consumerkey
consumer_secret = args.consumersecret
access_token = args.accesstoken
access_secret = args.accesssecret

auth = OAuthHandler(consumer_key, consumer_secret)
auth.set_access_token(access_token, access_secret)

def save_tweets():
    api = tweepy.API(auth)
    max_tweets = int(args.resultcount)
    searched_tweets = []
    last_id = -1

    while len(searched_tweets) < max_tweets:
        count = max_tweets - len(searched_tweets)
        try:
            new_tweets = api.search(q=keyword, count=count, max_id=str(last_id - 1))
            if not new_tweets:
                break
                
            searched_tweets.extend(new_tweets)
            last_id = new_tweets[-1].id
        except tweepy.TweepError as e:
            print(e)
            break
    
    outtweets = []

    for tweet in searched_tweets:
        a = '@' + tweet.author._json['screen_name'] + ' '

        for user in tweet._json['entities']['user_mentions']:
            a = a + '@' + user['screen_name'] + ' '
        
        outtweets.append([tweet.id, tweet.created_at, tweet.text.encode("utf-8"), a])
        
    new = pd.DataFrame(outtweets)
    return new

def save_file():    
    new = save_tweets()

    while (new.shape[0] == 0):
        new = save_tweets()
        
    new.to_csv('a.csv')
    
save_file()