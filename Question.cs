namespace TestShuffler
{
    public class Question
    {
        private string _text;
        private string _ans;
        private bool _verif;
        private int _pri;

        
        public string Text {
            get {return _text;} 
        }

        public string Ans {
            get {return _ans;}
        }

        public bool Verifiable {
            get {return _verif;}
        }

        public int Pri {
            get {return _pri;}
        }

        public Question(string t, string a, bool v, int p=9){
            _text = t;
            _ans = a;
            _verif = v;
            _pri = p;
        }

        public string Ask() {
            string? userAns;
            Console.WriteLine(Text);

            
            do{
                userAns = Console.ReadLine();
                if(userAns == null){
                    Console.WriteLine("Please enter a value: ");
                    Console.ReadLine();
                }
            } while(userAns == null);
            
            return userAns;
        }

        public bool Verify(string inp){
            if( Ans.Equals(inp) )
                return true;
            return false;
        }

        public void Test(){
            Console.WriteLine(Text);
        }

    }
}