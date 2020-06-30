using CulturaWeb.Domain.Notification;
using System;
using System.Collections.Generic;
using System.Text;

namespace CulturaWeb.Domain.Service
{
    public interface IServiceNotificador
    {
        bool TemNotificacao();
        IList<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}
