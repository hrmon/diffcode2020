// In the name of god

#include <stdio.h>

int main() {
  int n, t, i=0, se = 0, st = 0;
  scanf("%d %d", &n, &t);
  int me = -1 * t;
  int f = 0;
  for (i=0; i<n; i++){
    int e, d;
    scanf("%d %d", &d, &e);
    if (st + d > t || f){
      f = 1;
      continue;
    }
    se += e;
    st += d;
    if (se - (t - st) > me) {
      me = se - (t - st);
    }
  }
  printf("%d\n", me);
  return 0;
}
