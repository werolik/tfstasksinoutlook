﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;

namespace TFSTasksInOutlook
  {
  interface ITFSTaskPaneView
    {
    IObservable<Unit> OnConnectToTfs();
    IObservable<Unit> OnGoToReport();
    IObservable<WorkItemFilter> OnTaskFilterChanged();
    IObservable<WorkItemInfo> OnTaskDoubleClicked();
    IObservable<long> OnAddFavTask();
    IObservable<WorkItemInfo> OnRemoveFavorite();
    IObservable<WorkItemInfo> OnCopyToClipboard();

    void SetProjectsList(IEnumerable<string> projects);
    void SetTasksList(IEnumerable<WorkItemInfo> tasks);
    void SetFavTaskList(IEnumerable<WorkItemInfo> tasks);
    void SetBusyGetTasks(bool busy);
    void SetBusyAddFav(bool busy);
    }
  }
