using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Btn : MonoBehaviour
{
    // public InputField inputCoin;

    public ShopManager shopManager;
    public Button BtnAxe;
    public Button BtnArmor;
    public Button BtnBag;
    public Button BtnBelt;
    public Button BtnBook;
    public Button BtnBoots;
    public Button BtnRing;
    public Button BtnHelmets;
    public Button BtnPants;
    public Button BtnShield;
    public Button BtnSword;
    public Button BtnOk;
    public Button BtnExit;
    public Button BtnAddCoin;

    public GameObject OutStock;
    public GameObject PurchaseComplete;
    public GameObject NotMoney;
    public GameObject InputFieldCoin;


    public void Start()
    {
        //(10.ToString(),int.Parse("0123456789"), int.Parse(10), () => { });
    }
    public void BtnBuyAxe()
    {
        shopManager.BuyAxe();
        return;
            
    }
        
        



    
    public void BtnBuyArmor()
    {

        shopManager.BuyArmor();
        return;


    }
    public void BtnBuyBag()
    {

        shopManager.BuyBag();
        return;
    }
    public void BtnBuyBelt()
    {
        shopManager.BuyBelt();
        return;
    }

        public void BtnBuyBook()
    {
        shopManager.BuyBook();
        return;
    }
    public void BtnBuyBoots()
    {
        shopManager.BuyBoots();
        return;
    }
    public void BtnBuyRing()
    {
        shopManager.BuyRing();
        return;

    }
    public void BtnBuyHelmets()
    {
        shopManager.BuyHelmets();
        return;
    }
    public void BtnBuyPants()
    {
        shopManager.BuyPants();
        return;
    }
    public void BtnBuyShield()
    {
        shopManager.BuyShield();
        return;
    }
    public void BtnBuySword()
    {

        shopManager.BuySword();
        return;
    }
    public void Btnok()
    {
        OutStock.SetActive(false);
        PurchaseComplete.SetActive(false);
        NotMoney.SetActive(false);
    }
    public void Btnexit()
    {
        OutStock.SetActive(false);
        PurchaseComplete.SetActive(false);
        NotMoney.SetActive(false);
       // InputFieldCoin.SetActive(false);
    }
    //public void btnAddCoin()
    //{
        //InputFieldCoin.SetActive(true);
        //ShopManager.coinAmount += int.Parse(inputCoin.text) ;
        //return;
    //}
    //public  void Show (string title ,int characterLimit ,string Index, Action On)
    //{

      //  inputCoin.characterLimit  = characterLimit; 
    //}
}

