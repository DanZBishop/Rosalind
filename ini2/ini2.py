#!/usr/bin/python
# Solution to Rosalind problem ini2

import argparse

parser = argparse.ArgumentParser(description="Solves Rosalind problem ini2")
parser.add_argument("numbers", type=int, nargs=2, help="Numbers to sum squares of")

args = parser.parse_args()

sum = 0
for number in args.numbers:
	sum += number ** 2

print sum