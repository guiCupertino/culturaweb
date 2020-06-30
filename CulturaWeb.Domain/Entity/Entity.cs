namespace CulturaWeb.Domain.Entity
{
    public abstract class Entity
    {
        //private readonly V validator;

        //protected Entity()
        //{
        //    this.validator = new V();
        //}

        public int Id { get; set; }

        //public void Validate()
        //{
        //    var validationResult = this.validator.Validate(this);

        //    if (!validationResult.IsValid)
        //    {
        //        //var businessErrors = new List<BusinessError>();

        //        foreach (var erro in validationResult.Errors)
        //        {
        //            //var businessErro = new BusinessError
        //            //{
        //            //    Property = erro.PropertyName,
        //            //    Message = erro.ErrorMessage
        //            //};

        //            _notificador.Handle(new Notification.Notificacao(erro.ErrorMessage));
        //            //businessErrors.Add(businessErro);
        //        }

        //        //throw new BusinessException(businessErrors);
        //    }
        //}
    }
}
