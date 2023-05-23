using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    // busineste klasörlerden sonra manage nuget yapıp FluentValidation jeremy skinneri yaptık ve FluentValidation klasörüne bu classı ekledik 
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            // diğer özellikleri de araştır
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.ProductName).MinimumLength(2);
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1);
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Ürünler A harfi ile başlamalı");
        }
        //arg ProductName'ye denk geliyor
        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
