using System.IO;

namespace TestShuffler {
    public class Cat {
        private Question[] _questions;
        private Question[] _starred;
        private int _score;

        public Cat(string path){
            initText(path);
            _score = 0;
        }

        private void initText(string path){
            if (!File.Exists(path)){
                Console.WriteLine("  Cat initText:: ERROR - provided path does not exist");
                return;
            }

            string[] text = File.ReadAllLines(path);
            foreach(string line in text){
                Console.WriteLine(line);
            }

        }

        /*
        public void Run(){
            for(int i=0; i<MAX_PRI; i++){

            }
        }
        */
    }

}