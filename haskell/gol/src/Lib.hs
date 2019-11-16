module Lib
    ( summer
    ) where

summer :: (Show a, Num a) => a -> a -> String
summer x y = show $ x + y