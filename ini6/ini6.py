#!/usr/bin/python

import argparse

parser = argparse.ArgumentParser(description="Outputs even numbered lines from input file")
parser.add_argument("--input", "-i", required=True, help="Input file name")

args = parser.parse_args()

text = open(args.input, "r").read()
d = {}

for word in text.split(" "):
	if word in d:
		d[word] += 1
	else:
		d[word] = 1

for k,v in d.items():
	print k + " " + str(v)
