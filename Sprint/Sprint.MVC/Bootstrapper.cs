﻿using Autofac;
using Sprint.BL.Configs;

namespace Sprint.MVC;

public class Bootstrapper : IDisposable
{
    public IContainer Container { get; init; }

    public Bootstrapper()
    {
        Container = AutofacBLConfig.Configure();
    }

    public void Dispose()
    {
        Container.Dispose();
    }
}
