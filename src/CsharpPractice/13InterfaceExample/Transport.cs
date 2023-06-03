using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13InterfaceExample
{
    internal interface ITransport
    {
        //kokhono joid emon situation hoy j amr ei methds gula lagbe ja kokhn kothai implement hobe ta jana nei tokhon interface use korte hoy
        void StartEngine();
        void StopEngine();
        void Move();
        //Interface e methods er age kono access modifier ullekh na thakle seta public hisebe kaj kore
        //Interface er khetre dui kotha-
        //(1) Abstract class er moto interface er o instance create kora jaina
        //(2) Interface e ekadik interface inherit kora jai
        //Interface e kono variables,field property and constructor declare kora jabena only method likha jai tao implemet kora jetona
        //kintu .Net8 (2020) theke method implement kora jai & etar spesific karon o ache

    }
}

//Normal class e only implementetion kora jai, signature rakha jaina
//Abstract class e method er signature o rakha jai &  implement o kora jai
//Interface eo ekhn implementetion