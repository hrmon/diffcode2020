package main

import (
  "fmt"
  "sort"
)

func main(){
  var n int
  var ar [200]int
  fmt.Scanf("%d", &n)
  for i := 0; i < n; i++ {
    fmt.Scanf("%d", &ar[i])
  }
  sort.Ints(ar[:n])
  for j := 0; j<(n+1)/2; j++ {
    fmt.Printf("%d ", ar[n-j-1])
    if j < n-j-1 {
      fmt.Printf("%d ", ar[j])
    }
  }
}
