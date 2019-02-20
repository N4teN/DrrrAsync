﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DrrrAsync.AsyncEvents
{
    public static class EventExtensions
    {
        public static async void FireEventAsync<T>(this T e, params object[] args) where T : Delegate
        {
            var invokationList = (Func<Task>[])e.GetInvocationList();
            var handlerTasks = new List<Task>();

            foreach (var invokation in invokationList)
                handlerTasks.Add((Task) invokation.DynamicInvoke(args));
            await Task.WhenAll(handlerTasks);
        }
    }
}
