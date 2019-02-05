﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Task_Tracker.ViewModel.Commands
{
    class SubmitWorkLogCommand : ICommand
    {
        public WorkLogVM VM { get; set; }
        public event EventHandler CanExecuteChanged;

        public SubmitWorkLogCommand(WorkLogVM vm)
        {
            VM = vm;
        }

        public bool CanExecute ( object parameter )
        {
            return true;
        }

        public void Execute ( object parameter )
        {
            throw new NotImplementedException();
        }
    }
}
