import Test.Hspec
import Lib

main :: IO ()
main = hspec $  do
    describe "summer" $ do
        it "should sum and render" $ do
            (summer 4 2)`shouldBe` "6"