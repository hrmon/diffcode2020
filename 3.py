import re
from itertools import chain

lines = [str(input()) for i in range(9)]
pat_1 = r'(1|2){3}.{3}(1|2){3}'
pat_2 = r'(1|2)(0|2)(1|2).{3}(1|2)(0|2)(1|2)'

if not all([
   re.match(pat_1, lines[0]),
   re.match(pat_2, lines[1]),
   re.match(pat_1, lines[2]),
   re.match(pat_1, lines[-3]),
   re.match(pat_2, lines[-2]),
   re.match(pat_1, lines[-1]),
]):
    print(0)
else:
    ext = [line[3:6] for line in chain(lines[:3], lines[6:])]
    print(1 << ''.join(ext + lines[3:6]).count('2'))
