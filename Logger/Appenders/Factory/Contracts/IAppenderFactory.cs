﻿using System;
using System.Collections.Generic;
using System.Text;
using Logger.Appenders.Contracts;
using Logger.Layouts.Contracts;

namespace Logger.Appenders.Factory.Contracts
{
    public interface IAppenderFactory
    {
        IAppender CreateAppender(string type, ILayout layout);
    }
}
