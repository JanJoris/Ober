﻿using System;
using System.Threading.Tasks;
using Ober.Tool.Interfaces;
using Ober.Tool.Options;

namespace Ober.Tool.Commands
{
    internal class ShowCommand: CommandBase, IShowCommand
    {
        private ShowOptions _showOptions;

        public ShowCommand(IStoreClient client, ILogger logger) : base(client, logger) { }

        public async Task<int> ShowSubmission(ShowOptions options)
        {
            _showOptions = options;
            return await HandleCommand(options.ConfigFile, options.Verbose);
        }

        protected override Task<int> CommandLogic()
        {
            return Task<int>.Factory.StartNew(() =>
            {
                Console.WriteLine("The show command has not yet been implemented");
                return -1;
            });
        }
    }
}
