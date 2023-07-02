using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Interceptors;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Aspects.Autofac.Validation
{
    public class ValidationAspect : MethodInterception //Aspect
    {
        private Type _validatorType;
        public ValidationAspect(Type validatorType)
        {
            //defensive codes
            if (!typeof(IValidator).IsAssignableFrom(validatorType))
            {
                throw new System.Exception("Bu bir doğrulama sınıfı değil");
            }

            _validatorType = validatorType;
        }
        protected override void OnBefore(IInvocation invocation)
        {
            //Bellekte yeni bir new leme yapıyor ve productValidatoru alıyor
            var validator = (IValidator)Activator.CreateInstance(_validatorType);
            //AbstractValidator<Product> burası validator mu diye bakıyor ve ilk varlığı alııyor
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];
            //Add metodundaki tüm varlıkları geziyor ve product olanları listeleyip doğruluyor
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType);
            foreach (var entity in entities)
            {
                ValidationTool.Validate(validator, entity);
            }
        }
    }
}
