﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FileComparator
{
    public class Controller
    {
        const string FIRST_FILE_FILEPATH = @"/Users/patryklanger/inputFile.txt";
        const string SECOND_FILE_FILEPATH = @"/Users/patryklanger/inputFile1.txt";
        const string RESULT_FILE_FILEPATH = @"/Users/patryklanger/";
        const string RESULT_FILE_FILENAME = "result.txt";
        const string FILE_SAVED_MESSAGE = "FileSaved!";
        const string OPTIONS_MESSAGE = "Choose between two options:\nFirst option is";

        public Text firstText;
        public Text secondText;
        public Text resultText;
        public ITextComparator comparator;
        public PrimaryFileWorker fileWorker;
        public Controller(ITextComparator comparator, PrimaryFileWorker fileWorker)
        {
            this.comparator = comparator;
            this.fileWorker = fileWorker;
        }
        public async Task Main()
        {
            var text1 = new Text();
            var text2 = new Text();
            try
            {
                text1 = fileWorker.ReadFile(FIRST_FILE_FILEPATH);
                text2 = fileWorker.ReadFile(SECOND_FILE_FILEPATH);
            }
            catch (Exception e)
            {
                //view.DisplayText(e.Message);
            }
            comparator.MakeComparison(text1, text2);
            while (!comparator.MergeReady) if(!comparator.MakeDecision()) SolveConflict();
            Text resultText = comparator.ResultText;
            await fileWorker.SaveFile(resultText, RESULT_FILE_FILEPATH, RESULT_FILE_FILENAME).ContinueWith((antecdent) => Console.WriteLine(FILE_SAVED_MESSAGE));
        }
        private void SolveConflict()
        {
            //view.DisplayText(OPTIONS_MESSAGE);
            //view.DisplayTextWithNumber(1, comparator.Conflict.Item1);
            //view.DisplayTextWithNumber(2, comparator.Conflict.Item2);
            //var userChoise = view.WaitForUserInput();
            //if (userChoise == "1") comparator.ResolveConflict(0);
            //else comparator.ResolveConflict(1);
        } 
        
    }
}
