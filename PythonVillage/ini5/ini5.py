#!/usr/bin/python

import argparse

parser = argparse.ArgumentParser(description="Outputs even numbered lines from input file")
parser.add_argument("--input", "-i", required=True, help="Input file name")
parser.add_argument("-o", "--output", required=True, help="Output file name")

args = parser.parse_args()

inFile = open(args.input, "r")
outFile = open(args.output, "w")

count = 0

for line in inFile:
	count += 1
	if count % 2 == 0:
		outFile.write(line)

outFile.close()