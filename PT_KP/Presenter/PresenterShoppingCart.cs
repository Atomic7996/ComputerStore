using PT_KP.Model;
using PT_KP.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT_KP.Presenter
{
    public class PresenterShoppingCart
    {
        public IViewShoppingCart view;
        public CartRecord modelRecord;

        public PresenterShoppingCart(IViewShoppingCart view) 
        { 
            this.view = view;
        }

        public void RemoveItem(CartRecord record)
        {
            this.modelRecord = record;
            ShoppingCart.RemoveRecord(modelRecord);
        }

        public decimal ComputeTotalValue()
        {            
            return ShoppingCart.ComputeTotalValue(); ;
        }

        public void ClearShoppingCart()
        {
            ShoppingCart.ClearShoppingCart();
        }

        public List<CartRecord> GetRecords()
        {
            return ShoppingCart.GetRecords;
        }

        public string GetCompSpecification()
        {
            return this.view.SelectedCartRecord.Computer.GetSpecification();
        }
    }
}
