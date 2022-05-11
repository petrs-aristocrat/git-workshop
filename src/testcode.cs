namespace TestCode
{

    public class TestClass
    {

        private IList<string> _list = new IList<string>();

        public TestClass()
        {

            _list = new List<string>();


        }


        public void Add(string value) {
            _list.Add(value);
        }

        public string Delete(string value) {
            var idx = _list.FindIndex(x => x == value);

            if(idx >= 0) {
                _list.RemoveAt(idx);
            }

        }

    }


}