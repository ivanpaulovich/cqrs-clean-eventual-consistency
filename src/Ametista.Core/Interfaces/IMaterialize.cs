﻿using System.Threading.Tasks;

namespace Ametista.Core
{
    public interface IMaterialize<TEvent> where TEvent : IEvent
    {
        Task<bool> Materialize(TEvent e);
    }
}
