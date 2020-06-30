using CulturaWeb.Domain.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CulturaWeb.Domain.Notification
{
    public class ServiceNotificador : IServiceNotificador
    {
        public IList<Notificacao> _notificacoes { get; set; }
        public ServiceNotificador()
        {
            _notificacoes = new List<Notificacao>();
        }

        public void Handle(Notificacao notificacao)
        {
            _notificacoes.Add(notificacao);
        }

        public IList<Notificacao> ObterNotificacoes()
        {
            return _notificacoes;
        }

        public bool TemNotificacao()
        {
            return _notificacoes.Any();
        }
    }
}
