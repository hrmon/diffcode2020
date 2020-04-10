import re
import math

def gcd(a,b):
    if b == 0:
        return a
    return gcd(b, a%b)


def parse(l):
    sg = l[0] != '-'
    l = l if l[0] != '-' else l[1:]

    co = 0
    mx = 0

    while l:
        nx = l.find('+')
        if 0 <= l.find('-') < nx or nx < 0:
            nx = l.find('-')
        nx = 10000 if nx < 0 else nx

        ml = l[:nx]
        if ml[-1] == 'x':
            mx += (1 if sg else -1) * (1 if not ml[:-1] else int(ml[:-1]))
        else:
            co += (1 if sg else -1) * (1 if not ml else int(ml))

        sg = 0 if nx >= len(l) else l[nx] != '-'
        l = l[nx+1:]

    return co, mx


n = int(input())
exp = input()
le,ri = exp.split('=')
a, x = parse(le)
b, y = parse(ri)


if x == y:
    print('invalid')
else:
    p = a-b
    q = y-x
    g = gcd(p,q)
    p /= g
    q /= g
    if q < 0:
        p *= -1
        q *= -1
    print('%d %d' % (p, q))


