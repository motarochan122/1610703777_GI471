using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{


    // public static int coin;

    public int coinAmount;
    public int axeAmout;
    public int armorAmount;
    public int bagAmount;
    public int beltAmount;
    public int bookAmount;
    public int bootsAmount;
    public int ringAmount;
    public int helmetsAmount;
    public int pantsAmount;
    public int shieldAmount;
    public int swordAmount;

    public Text TextCoin;
    public Text TextAxe;
    public Text TextArmor;
    public Text TextBag;
    public Text TextBelt;
    public Text TextBook;
    public Text TextBoots;
    public Text TextRing;
    public Text TextHelmets;
    public Text TextPants;
    public Text TextShield;
    public Text TextSword;




    public int axePrize;
    public int armorPrize;
    public int bagPrize;
    public int beltPrize;
    public int bookPrize;
    public int bootsPrize;
    public int ringPrize;
    public int helmetsPrize;
    public int pantsPrize;
    public int shieldPrize;
    public int swordPrize;

    public GameObject OutStock;
    public GameObject PurchaseComplete;
    public GameObject NotMoney;
    public GameObject InputFieldCoin;

    public Image ImageItem;
    public Text TextComp;

    public Sprite imageAxe;
    public Sprite imageArmor;
    public Sprite imageBag;
    public Sprite imageBelt;
    public Sprite imageBook;
    public Sprite imageBoots;
    public Sprite imageRing;
    public Sprite imageHelmets;
    public Sprite imagePants;
    public Sprite imageShield;
    public Sprite imageSword;






    void Start()
    {
        //Coin
        coinAmount = 1000000;
        //AmountOfItem
        axeAmout = 5;
        armorAmount = 5;
        bagAmount = 5;
        beltAmount = 5;
        bookAmount = 5;
        bootsAmount = 5;
        ringAmount = 5;
        helmetsAmount = 5;
        pantsAmount = 5;
        shieldAmount = 5;
        swordAmount = 5;
        //ItemPrize
        axePrize = 200;
        armorPrize = 300;
        bagPrize = 100;
        beltPrize = 200;
        bookPrize = 50;
        bootsPrize = 150;
        ringPrize = 60;
        helmetsPrize = 300;
        pantsPrize = 100;
        shieldPrize = 500;
        swordPrize = 600;



    }
    //public void CoinUpdate()
    //{
    //  coinAmount = coin;
    //}
    //public void ItemUpdate()
    //{

    //}

    // Update is called once per frame
    void Update()
    {
        TextCoin.text = "Coin : " + coinAmount.ToString();
        TextAxe.text = " Axe         " + axeAmout + "   EA  " + axePrize + "  Bath";
        TextArmor.text = " Armor     " + armorAmount + "   EA  " + armorPrize + "  Bath";
        TextBag.text = " Bag         " + bagAmount + "   EA  " + bagPrize + "  Bath";
        TextBelt.text = " Belt         " + beltAmount + "   EA  " + beltPrize + "   Bath";
        TextBook.text = " Book       " + bookAmount + "   EA    " + bookPrize + "   Bath";
        TextBoots.text = " Boots      " + bootsAmount + "   EA    " + bookPrize + "   Bath";
        TextRing.text = " Ring        " + ringAmount + "   EA    " + ringPrize + "   Bath";
        TextHelmets.text = " Helmets   " + helmetsAmount + "   EA  " + helmetsPrize + "  Bath";
        TextPants.text = " Pants       " + pantsAmount + "   EA  " + pantsPrize + "  Bath";
        TextShield.text = " Shield      " + shieldAmount + "   EA  " + shieldPrize + "  Bath";
        TextSword.text = " Sword      " + swordAmount + "   EA  " + swordPrize + "  Bath";
    }
    public void BuyAxe()
    {
        if (axeAmout > 0)
        {
            if (coinAmount >= axePrize)
            {


                ImageItem.sprite = imageAxe;
                TextComp.text = "Purchase Axe Complete";
                PurchaseComplete.SetActive(true);
                coinAmount -= axePrize;
                axeAmout -= 1;
                print("Axe" + axeAmout + "Coin" + coinAmount);

                return;

            }
            else if (coinAmount < axePrize)
            {
                NotMoney.SetActive(true);
            }
            else
            {

            }
        }
        else
        {
            OutStock.SetActive(true);
        }
    }
    public void BuyArmor()
    {
        if (armorAmount > 0)
        {
            if (coinAmount >= armorPrize)
            {
                PurchaseComplete.SetActive(true);
                ImageItem.sprite = imageBag;
                TextComp.text = "Purchase Bag Complete";
                coinAmount -= armorPrize;
                armorAmount -= 1;
                return;
            }
            else if (coinAmount < armorPrize)
            {
                NotMoney.SetActive(true);
            }
            else
            {
                return;
            }

        }
        else
        {
            OutStock.SetActive(true);
        }
    }
    public void BuyBag()
    {
        if (bagAmount > 0)
        {
            if (coinAmount >= bagPrize)
            {
                PurchaseComplete.SetActive(true);
                ImageItem.sprite = imageBag;
                TextComp.text = "Purchase Bag Complete";
                coinAmount -= bagPrize;
                bagAmount -= 1;
                return;
            }
            else if (coinAmount < bagPrize)
            {
                NotMoney.SetActive(true);
            }
            else
            {
                return;
            }

        }
        else
        {
            OutStock.SetActive(true);
        }
    }
    public void BuyBelt()
    {
        if (beltAmount > 0)
        {
            if (coinAmount >= beltPrize)
            {
                ImageItem.sprite = imageBelt;
                TextComp.text = "Purchase Belt Complete";
                PurchaseComplete.SetActive(true);
                coinAmount -= beltPrize;
                beltAmount -= 1;
                return;
            }
            else if (coinAmount < beltPrize)
            {
                NotMoney.SetActive(true);
            }
            else
            {
                return;
            }

        }
        else
        {
            OutStock.SetActive(true);
        }
    }

    public void BuyBook()
    {
        if (bookAmount > 0)
        {
            if (coinAmount >= bookPrize)
            {
                ImageItem.sprite = imageBook;
                TextComp.text = "Purchase Book Complete";
                PurchaseComplete.SetActive(true);
                coinAmount -= bootsPrize;
                bookAmount -= 1;
                return;
            }
            else if (coinAmount < bookPrize)
            {
                NotMoney.SetActive(true);
            }
            else
            {
                return;
            }


        }
        else
        {
            OutStock.SetActive(true);
        }
    }

    public void BuyBoots()
    {
        if (bootsAmount > 0)
        {
            if (coinAmount >= bookPrize)
            {
                ImageItem.sprite = imageBoots;
                TextComp.text = "Purchase Boots Complete";
                PurchaseComplete.SetActive(true);
                coinAmount -= bootsPrize;
                bootsAmount -= 1;
                return;
            }
            else if (coinAmount < bootsPrize)
            {
                NotMoney.SetActive(true);
            }
            else
            {
                return;
            }
        }
        else
        {
            OutStock.SetActive(true);
        }
    }

    public void BuyRing()
    {
        if (ringAmount > 0)
        {
            if (coinAmount >= ringPrize)
            {
                ImageItem.sprite = imageRing;
                TextComp.text = "Purchase Ring Complete";
                PurchaseComplete.SetActive(true);
                coinAmount -= ringPrize;
                ringAmount -= 1;
                return;
            }
            else if (coinAmount < ringPrize)
            {
                NotMoney.SetActive(true);
            }
            else
            {
                return;
            }
        }
        else
        {
            OutStock.SetActive(true);
        }
    }

    public void BuyHelmets()
    {
        if (helmetsAmount > 0)
        {
            OutStock.SetActive(true);

            if (coinAmount >= helmetsPrize)
            {
                ImageItem.sprite = imageHelmets;
                TextComp.text = "Purchase Helmets Complete";
                PurchaseComplete.SetActive(true);
                coinAmount -= helmetsPrize;
                helmetsAmount -= 1;
                return;
            }
            else if (coinAmount < helmetsPrize)
            {
                NotMoney.SetActive(true);
            }
            else
            {
                return;
            }
        }
        else
        {
            OutStock.SetActive(true);
        }
    }

    public void BuyPants()
    {
        if (pantsAmount > 0)
        {

            if (coinAmount >= pantsPrize)
            {
                ImageItem.sprite = imagePants;
                TextComp.text = "Purchase Pants Complete";
                PurchaseComplete.SetActive(true);
                coinAmount -= pantsPrize;
                pantsAmount -= 1;
                return;
            }
            else if (coinAmount < pantsPrize)
            {
                NotMoney.SetActive(true);
            }


            else
            {
                return;
            }
        }
        else
        {
            OutStock.SetActive(true);
        }
    }

    public void BuyShield()
    {
        if (shieldAmount > 0)
        {

            if (coinAmount >= shieldPrize)
            {
                ImageItem.sprite = imageShield;
                TextComp.text = "Purchase Shield Complete";
                PurchaseComplete.SetActive(true);
                coinAmount -= shieldPrize;
                shieldAmount -= 1;
                return;
            }
            else if (coinAmount < shieldPrize)
            {
                NotMoney.SetActive(true);
            }
            if (shieldAmount <= 0)
            {
                OutStock.SetActive(true);
            }
            else
            {
                return;
            }
        }
        else
        {
            OutStock.SetActive(true);
        }
    }
    public void BuySword()
    {
        if (swordAmount > 0)
        {
            if (coinAmount >= swordPrize)
            {
                ImageItem.sprite = imageSword;
                TextComp.text = "Purchase Sword Complete";
                PurchaseComplete.SetActive(true);
                coinAmount -= swordPrize;
                swordAmount -= 1;
                return;
            }
            else if (coinAmount < swordPrize)
            {
                NotMoney.SetActive(true);
            }
            else
            {

                return;
            }


        }
        else
        {
            OutStock.SetActive(true);
            return;
        }
    }
}



