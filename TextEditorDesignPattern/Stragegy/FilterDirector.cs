using System;
using System.Collections.Generic;
using System.Text;
using TextEditorDesignPattern.Builder;

namespace TextEditorDesignPattern.Stragegy
{
    public class FilterDirector
    {
        FilterSpecialText filterAlgo;

        public FilterDirector()
        {
        }

        public FilterDirector(FilterSpecialText algoInput)
        {
            this.filterAlgo = algoInput;
        }

        public void SetFilterAlgorithm(FilterSpecialText algoInput)
        {
            filterAlgo = algoInput;
        }
        public string GetFilterText(Text text)
        {
            return filterAlgo.GetText(text);
        }
    }
}
