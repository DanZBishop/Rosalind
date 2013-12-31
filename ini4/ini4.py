#!/usr/bin/python

import argparse

parser = argparse.ArgumentParser(description="Counts odd numbers between two given numbers")
parser.add_argument("number", type=int, nargs=2, help="Range to count between")

args = parser.parse_args()

sum = 0

for i in range(args.number[0], args.number[1]):
	if i%2==1:
		sum += i

print sum