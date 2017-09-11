using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;

namespace ApplicationCore.Specifications
{
    class BasketWithItemsSpecification : ISpecification<Basket>
    {
        public BasketWithItemsSpecification(int basketId)
        {
            BasketId = basketId;
            AddInclude(b => b.Items);
        }

        public BasketWithItemsSpecification(string buyerId)
        {
            BuyerId = buyerId;
            AddInclude(b => b.Items);
        }

        public int? BasketId { get; }
        public string BuyerId { get; }

        public Expression<Func<Basket, bool>> Critiria => b => (BasketId.HasValue && b.Id == BasketId.Value) || (BuyerId != null && b.BuyerId == BuyerId);

        public List<Expression<Func<Basket, object>>> Includes { get; } = new List<Expression<Func<Basket, object>>>();

        public void AddInclude(Expression<Func<Basket, object>> includeExpression)
        {
            Includes.Add(includeExpression);
        }
    }
}
