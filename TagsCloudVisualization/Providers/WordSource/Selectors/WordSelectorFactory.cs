﻿using System.Collections.Generic;
using TagsCloudVisualization.Providers.WordSource.Interfaces;
using TagsCloudVisualization.Settings;

namespace TagsCloudVisualization.Providers.WordSource.Selectors
{
    internal class WordSelectorFactory : ISelectorFactory
    {
        public IEnumerable<IWordSelector> GetSelectors(ReaderSettings readerSettings)
        {
            yield return new GoodWordsWordSelector(readerSettings.BadWords);
            //Библиотека оказалась для Framework'a , оставил просто как пример добавления
            // yield return new NounsSelector();
        }
    }
}