using System.IO;
using static TestShuffler.Utils;

namespace TestShuffler {
    public class Cat {
        private List<Question> _questions;
        private List<Question> _starred;
        private int _score;

        public Cat(string path){
            _questions = new List<Question>();
            _starred   = new List<Question>();

            initText(path);
            _score = 0;

            Console.WriteLine("\n\nTESTING CAT");
            for(int i=0; i<_questions.Count; i++){
                Console.WriteLine(_questions[i].Text);
                Console.WriteLine(_questions[i].Ans);
                Console.WriteLine();
            }
        }

        private void initText(string path){
            if (!File.Exists(path)){
                Console.WriteLine("  Cat initText:: ERROR - provided path does not exist");
                return;
            }

            string curQ = "";
            string curA = "";

            string[] text = File.ReadAllLines(path);
            foreach(string line in text){
                Console.WriteLine(line);
                if(startCount(line,'/') >= 2 || string.IsNullOrEmpty(line) )
                    continue;
                
                // if line starts with whitespace, then it is an answer to the current question
                if(char.IsWhiteSpace(line, 0)){
                    curA = line;
                }
                // otherwise, it is a question
                else{
                    curQ = line;
                }

                Question q = new Question(curQ, curA);
                _questions.Add(q);
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