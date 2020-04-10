main = do
    x <- getLine
    mapM_ putStrLn  [(echo i x) | i <- [0..(length x -1)]]

echo n t = (replicate (n+1) (t !! n)) ++ (drop (n+1) t)