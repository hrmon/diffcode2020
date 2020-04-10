// In the name of god

#include <stdio.h>

int main() {
  int n, i=0;
  scanf("%d", &n);
  for (i=0; i<n; i++){
    int x;
    scanf("%d", &x);
    if (x<4){
      for (int j=0; j<x; j++)
        printf("*");
    } else {
      printf("*");
    }
    printf("\n");
  }
  return 0;
}
