﻿using System.Collections.Generic;
using System.Linq;
using TagsCloudVisualization.Providers.WordSource.Interfaces;

namespace TagsCloudVisualization.Providers.WordSource
{
    internal class TextSplitter : IWordReader
    {
        public IEnumerable<string> SplitByPunctuation(IEnumerable<string> lineSource)
        {
            foreach (var line in lineSource)
            {
                var punctuation = line.Where(char.IsPunctuation).Distinct().ToArray();
                foreach (var word in line.Split().Select(x => x.Trim(punctuation)))
                {
                    yield return word;
                }
            }
        }
    }
}