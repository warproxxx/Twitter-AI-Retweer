#requirements: pyemd, gensim, pandas, numpy
from gensim.models import Word2Vec
from gensim.models import KeyedVectors
import pandas as pd
import re
import time
import os.path


#f = open("opened.txt","w+")
#f.write("abc")
#f.close()

model = KeyedVectors.load_word2vec_format("E:\Glove Vector\glove.twitter.27B\glove.twitter.27B.100d.word2vec.txt", binary=False)

def cleanData(tweet):
    patterns = [
                'RT ', #RT text
                #'(?:\#+[\w_]+[\w\'_\-]*[\w_]+)', #hashtags
                '(?:@[\w_]+)',  # @-mentions
                'http[s]?://(?:[a-z]|[0-9]|[$-_@.&amp;+]|[!*\(\),]|(?:%[0-9a-f][0-9a-f]))+',  # URLs'
                '([^a-zA-Z ]+?)',
                'b '#anything else except text
                ]

    sub_pattern = re.compile('|'.join(patterns))
    
    if isinstance(tweet, pd.Series):
        return tweet.str.replace(sub_pattern, '').str.strip()
    else:
        return re.sub(sub_pattern, '', tweet).strip()

        
#f = open("gensim.txt","w+")
#f.write("abc")
#f.close()

print('gensim loaded')

while (True):
    time.sleep(1)

    if (os.path.isfile('a.csv')):
        df = pd.read_csv('a.csv')
        df['2'] = df['2'].apply(lambda x: x[1:] if x[:1] == 'b' else x)
        df['2'] = df['2'].apply(lambda x: x[1:] if x[:2] == ' ' else x)
        df['2'] = df['2'].apply(cleanData)

        distances = []

        f = open('tweet.txt')

        for line in f:
            realTweet = line
            
        realTweet = cleanData(realTweet)
        #print(realTweet)

        for tweet in df['2']:
            distances.append(model.wmdistance(realTweet, tweet))
        
        f.close()

        #f = open('distances', mode='w+')
        #f.write("\n".join(map(str, distances)))
        #f.close()

        high = pd.DataFrame(columns=['ID', 'Timestamp', 'Tweet'])
        medium = pd.DataFrame(columns=high.columns)
        low = pd.DataFrame(columns=medium.columns)
        all = pd.DataFrame(columns=low.columns)

        for i, distance in enumerate(distances):
            #print(distance)
            
            if (distance < 1.8):
                high = high.append({'ID': df.iloc[i]['0'], 'Timestamp': df.iloc[i]['1'], 'Tweet': df.iloc[i]['2'], 'Username': df.iloc[i]['3']}, ignore_index=True)
            
            if (distance < 2.2):
                medium = medium.append({'ID': df.iloc[i]['0'], 'Timestamp': df.iloc[i]['1'], 'Tweet': df.iloc[i]['2'], 'Username': df.iloc[i]['3']}, ignore_index=True)
            
            if (distance < 3):
                low = low.append({'ID': df.iloc[i]['0'], 'Timestamp': df.iloc[i]['1'], 'Tweet': df.iloc[i]['2'], 'Username': df.iloc[i]['3']}, ignore_index=True)

            all = all.append({'ID': df.iloc[i]['0'], 'Timestamp': df.iloc[i]['1'], 'Tweet': df.iloc[i]['2'], 'Username': df.iloc[i]['3']}, ignore_index=True)

        high.to_csv('high.csv', header=False, index=False)
        medium.to_csv('medium.csv', header=False, index=False)
        low.to_csv('low.csv', header=False, index=False)
        all.to_csv('all.csv', header=False, index=False)

        os.remove('a.csv')