﻿using System;

namespace RemoteControl
{
    public class OperationsClient
    {
        public void On<TResult, TParameter>(string operationName, Func<TParameter, TResult> operation)
        {
            
        }
    }
}
