#!/usr/bin/python

import argparse

parser = argparse.ArgumentParser(description="Slices a given string between given indices")
parser.add_argument("input_string", type=str, nargs=1, help="String to slice")
parser.add_argument("slice_ranges", type=int, nargs=4, help="Indices to slice")

args = parser.parse_args()

string = args.input_string[0]

print string[args.slice_ranges[0]:args.slice_ranges[1]+1] + " " + string[args.slice_ranges[2]:args.slice_ranges[3]+1]