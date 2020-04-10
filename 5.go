package main

import (
  "fmt"
)

func main(){
  n := 0
  m := 0
  for i := 0; i < 4; i++ {
    for j := 0; j < 3; j++ {
      var x int
      fmt.Scanf("%d", &x)
      if x >= m {
        m = x
        n = i
      }
    }
  }
  fmt.Printf("%d", n+1)
}
