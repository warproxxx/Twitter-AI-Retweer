import tweepy
from tweepy import OAuthHandler
import argparse, sys

import pandas as pd

parser=argparse.ArgumentParser()

parser.add_argument('--consumerkey', help='Twitter API Consumer Key')
parser.add_argument('--consumersecret', help='Twitter API Consumer Key')
parser.add_argument('--accesstoken', help='Twitter API Access Token')
parser.add_argument('--accesssecret', help='Twitter API Access Secret')
parser.add_argument('--file', help='File to open')

args=parser.parse_args()

consumer_key = args.consumerkey
consumer_secret = args.consumersecret
access_token = args.accesstoken
access_secret = args.accesssecret


auth = OAuthHandler(consumer_key, consumer_secret)
auth.set_access_token(access_token, access_secret)

api = tweepy.API(auth)

df = pd.read_csv(args.file + '.csv', header=None)

with open("retweetmessage.txt") as f:
    retweetMess = f.readlines()

for idx, data in df.iterrows():
    mess = data[3] + retweetMess[0]
    update = api.update_status(mess, in_reply_to_status_id = data[0])