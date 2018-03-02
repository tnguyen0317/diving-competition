﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simhopp
{
    public delegate void DelegateAddJump();
    public delegate void DelegateSubContestSelection();
    public delegate void DelegateContestantSelection();
    public delegate void DelegateDiveSelection();
    public delegate void DelegatePauseContest();
    public delegate void DelegateCloseContest();

    public interface IContestView
    {
        event DelegateAddJump EventAddJump;
        event DelegateSubContestSelection EventSubContestSelection;
        event DelegateContestantSelection EventContestantSelection;
        event DelegateDiveSelection EventDiveSelection;
        event DelegatePauseContest EventPauseContest;
        event DelegateCloseContest EventCloseContest;
    }
}