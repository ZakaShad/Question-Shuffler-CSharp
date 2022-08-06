namespace TestShuffler{
    static class Consts{
        const int MAX_PRI = 9;
    }

    static class Utils {
        public static int startCount(string text, char start){
            int count = 0;
            for(int i=0; i<text.Length; i++){
                if(text[i] == start)
                    count++;
                else
                    break;
            }
            return count;
        }

    }
}