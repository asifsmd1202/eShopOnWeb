using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;

namespace ApplicationCore.Specifications
{
    class CatalogFilterSpecification : ISpecification<CatalogItem>
    {
        public CatalogFilterSpecification(int? bandId, int? typeId)
        {
            BrandId = bandId;
            TypeId = typeId;
        }

        public int? BrandId { get; }
        public int? TypeId { get; }

        public Expression<Func<CatalogItem, bool>> Critiria => i => (!BrandId.HasValue || i.CatalogBrandId == BrandId) && (!TypeId.HasValue || i.CatalogTypeId == TypeId);

        public List<Expression<Func<CatalogItem, object>>> Includes { get; } = new List<Expression<Func<CatalogItem, object>>>();

        public void AddInclude(Expression<Func<CatalogItem, object>> includeExpression)
        {
            Includes.Add(includeExpression);
        }
    }
}
