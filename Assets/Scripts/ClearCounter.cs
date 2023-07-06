using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : BaseCounter
{
    
    
    [SerializeField] private KitchenObjectSO kitchenObjectSO;



  

    public override void Interact(Player player)
    {
        if (!HasKitchenObject())
        {
            //There is no kitchenObject
            if (player.HasKitchenObject())
            {
                player.GetKitchenObject().SetKitchenObjectParent(this);
            }
            else {
                //player not carrying anything
            }
        }
        else
        {
            // there is a kitchenobject
            if(player.HasKitchenObject())
            {
                //player carrying something
            }
            else
            {
                //player is not carrying anything
                GetKitchenObject().SetKitchenObjectParent(player);
            }

        }

    }


}
