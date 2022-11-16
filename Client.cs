using System;

namespace FortniteEmulator
{
    internal class Client
    {
        public static string GetClientArgs(string client, string type)
        {
            string clientArgs = null;
            if (type == "BattlEye")
            {
                //Season1&2
                if (client == "Cert")
                    clientArgs = "-noeac -frombe";
                if (client == "Live")
                    clientArgs = "-noeac -frombe";
                if (client == "2.2.0")
                    clientArgs = "-noeac -frombe";
                if (client == "2.3.0")
                    clientArgs = "-noeac -frombe";
                if (client == "2.3.2")
                    clientArgs = "-noeac -frombe";
                if (client == "2.4.0")
                    clientArgs = "-noeac -frombe";
                if (client == "2.4.2")
                    clientArgs = "-noeac -frombe";
                if (client == "2.4.x")
                    clientArgs = "-noeac -frombe";
                if (client == "2.5")
                    clientArgs = "-noeac -frombe";
                //Season3
                if (client == "3.0.0")
                    clientArgs = "-noeac -frombe";
                if (client == "3.1")
                    clientArgs = "-noeac -frombe";
                if (client == "3.2")
                    clientArgs = "-noeac -frombe";
                if (client == "3.3")
                    clientArgs = "-noeac -frombe";
                if (client == "3.4")
                    clientArgs = "-noeac -frombe";
                if (client == "3.5")
                    clientArgs = "-noeac -frombe";
                if (client == "3.6")
                    clientArgs = "-noeac -frombe";
                //season4
                if (client == "4.0")
                    clientArgs = "-noeac -frombe";
                if (client == "4.1")
                    clientArgs = "-noeac -frombe";
                if (client == "4.2")
                    clientArgs = "-noeac -frombe";
                if (client == "4.3")
                    clientArgs = "-noeac -frombe";
                if (client == "4.4")
                    clientArgs = "-noeac -frombe";
                if (client == "4.4.x")
                    clientArgs = "-noeac -frombe";
                if (client == "4.5")
                    clientArgs = "-noeac -frombe";
                //season5
                if (client == "5.0")
                    clientArgs = "-noeac -frombe";
                if (client == "5.10")
                    clientArgs = "-noeac -frombe";
                if (client == "5.20")
                    clientArgs = "-noeac -fromfl=be -frombe";
                if (client == "5.21")
                    clientArgs = "-noeac -fromfl=be -frombe";
                if (client == "5.30")
                    clientArgs = "-noeac -fromfl=be -frombe";
                if (client == "5.40")
                    clientArgs = "-noeac -fromfl=be -frombe";
                if (client == "5.41")
                    clientArgs = "-noeac -fromfl=be -frombe";
                //season6
                if (client == "6.00")
                    clientArgs = "-noeac -fromfl=be -frombe";
                if (client == "6.01")
                    clientArgs = "-noeac -fromfl=be -frombe";
                if (client == "6.02")
                    clientArgs = "-noeac -fromfl=be -frombe";
                if (client == "6.02")
                    clientArgs = "-noeac -fromfl=be -frombe";
                if (client == "6.10")
                    clientArgs = "-noeac -fromfl=be -fltoken=8682a0abb2b3ee86d8c2bc403b372f59626d0609700108131a5b5b443c4eb4beada99a99f6808883fbeaa6d1d1decec835777729 -frombe";
                if (client == "6.20")
                    clientArgs = "-noeac -fromfl=be -fltoken=858da0abb2b3ee86d8c2bc403b372f59626d0609700108131a5b5b443c4eb4beada99a99f6808883fbeaa6d1d189909b6077717810121e -frombe";
                if (client == "6.21")
                    clientArgs = "-noeac -fromfl=be -fltoken=858da0abb2b3ee86d8c2bc403b372f59626d0609700108131a5b5b443c4eb4beada99a99f6808883fbeaa6d1d189909b6077717810121e -frombe";
                if (client == "6.22")
                    clientArgs = "-noeac -fromfl=be -fltoken=858da0abb2b3ee86d8c2bc403b372f59626d0609700108131a5b5b443c4eb4beada99a99f6808883fbeaa6d1d189909b6077717810121e -frombe";
                if (client == "6.30")
                    clientArgs = "-noeac -fromfl=be -fltoken=8483a0abb2b3ee86d8c2bc403b372f59626d0609700108131a5b5b443c4eb4beada99a99f6808883fbeaa6d1d18a929b6077257f10441e -frombe";
                if (client == "6.31")
                    clientArgs = "-noeac -fromfl=be -fltoken=8483a0abb2b3ee86d8c2bc403b372f59626d0609700108131a5b5b443c4eb4beada99a99f6808883fbeaa6d1d18a929b6077257f10441e -frombe";
                //season7
                if (client == "7.00")
                    clientArgs = "-noeac -fromfl=be -fltoken=868ba0abb2b3ee86d8c2bc403b372f59626d0609700108131a5b5b443c4eb4beada99a99f6808883fbeaa6d1d189909b6077242810441e -frombe";
                if (client == "7.01")
                    clientArgs = "-noeac -fromfl=be -fltoken=868ba0abb2b3ee86d8c2bc403b372f59626d0609700108131a5b5b443c4eb4beada99a99f6808883fbeaa6d1d189909b6077242810441e -frombe";
                if (client == "7.10")
                    clientArgs = "-noeac -fromfl=be -fltoken= -frombe";
                if (client == "7.20")
                    clientArgs = "-noeac -fromfl=be -fltoken= -frombe";
                if (client == "7.30")
                    clientArgs = "-noeac -fromfl=be -fltoken=72bd8be891999da578b9643a -frombe";
                if (client == "7.40")
                    clientArgs = "-noeac -fromfl=be -fltoken=1d29g022h4h5050906g9d7b6 -frombe";
                //season8
                if (client == "8.00")
                    clientArgs = "-noeac -fromfl=be -fltoken=575862a9847575858c8c4418 -frombe";
                if (client == "8.01")
                    clientArgs = "-noeac -fromfl=be -fltoken=575862a9847575858c8c4418 -frombe";
                if (client == "8.10")
                    clientArgs = "-noeac -fromfl=be -fltoken= -frombe";
                if (client == "8.11")
                    clientArgs = "-noeac -fromfl=be -fltoken= -frombe";
                if (client == "8.20")
                    clientArgs = "-noeac -fromfl=be -fltoken=b974d2d6d9dce4ecf0g1a385 -frombe";
                if (client == "8.30")
                    clientArgs = "-noeac -fromfl=be -fltoken=2226g567h0i0ha020313d2b1 -frombe";
                if (client == "8.40")
                    clientArgs = "-noeac -fromfl=be -fltoken=8994f5acac5dbcc159ca7cd6 -frombe";
                if (client == "8.50")
                    clientArgs = "-noeac -fromfl=be -fltoken=4d666a6cba208788919d4Cg0 -frombe";
                if (client == "8.51")
                    clientArgs = "-noeac -fromfl=be -fltoken=4d666a6cba208788919d4Cg0 -frombe";
                //season9
                if (client == "9.00")
                    clientArgs = "-noeac -fromfl=be -fltoken=0903101217273437h6440042 -frombe";
                if (client == "9.01")
                    clientArgs = "-noeac -fromfl=be -fltoken=0903101217273437h6440042 -frombe";
                if (client == "9.10")
                    clientArgs = "-noeac -fromfl=be -fltoken=d5c8a09aa5b1bab75ad077c1 -frombe";
                if (client == "9.20")
                    clientArgs = "-noeac -fromfl=be -fltoken=h08336393d494d5d64722200 -frombe";
                if (client == "9.21")
                    clientArgs = "-noeac -fromfl=be -fltoken=h08336393d494d5d64722200 -frombe";
                if (client == "9.30")
                    clientArgs = "-noeac -fromfl=be -fltoken=1af0g2g0h7b305040c19d45c -frombe";
                if (client == "9.40")
                    clientArgs = "-noeac -fromfl=be -fltoken=b1bcbad787bde9f1f5f99fa4 -frombe";
                if (client == "9.41")
                    clientArgs = "-noeac -fromfl=be -fltoken=b1bcbad787bde9f1f5f99fa4 -frombe";
                //season10
                if (client == "10.0")
                    clientArgs = "-noeac -fromfl=be -fltoken=6dab8383579a04abacc565e0 -frombe";
                if (client == "10.10")
                    clientArgs = "-noeac -fromfl=be -fltoken=hbi2hc06dah41c283235f04c -frombe";
                if (client == "10.20")
                    clientArgs = "-noeac -fromfl=be -fltoken=a1bdab73c4bbd0d50de489b8 -frombe";
                if (client == "10.30")
                    clientArgs = "-noeac -fromfl=be -fltoken=g5gah6i3hae4111d1b24e160 -frombe";
                if (client == "10.31")
                    clientArgs = "-noeac -fromfl=be -fltoken=g5gah6i3hae4111d1b24e160 -frombe";
                if (client == "10.40")
                    clientArgs = "-noeac -fromfl=be -fltoken=8bdba2a4a6c3c4c88bd87fd2 -frombe";
                //season11
                if (client == "11.00")
                    clientArgs = "-noeac -fromfl=be -fltoken=46da55556b606d79d8893ah5 -frombe";
                if (client == "11.01")
                    clientArgs = "-noeac -fromfl=be -fltoken=46da55556b606d79d8893ah5 -frombe";
                if (client == "11.10")
                    clientArgs = "-noeac -fromfl=be -fltoken=b2f1ba5cd7cae3e420f598a5 -frombe";
                if (client == "11.11")
                    clientArgs = "-noeac -fromfl=be -fltoken=b2f1ba5cd7cae3e420f598a5 -frombe";
                if (client == "11.20")
                    clientArgs = "-noeac -fromfl=be -fltoken=81e9e7f9faf320h1h7habd89 -frombe";
                if (client == "11.21")
                    clientArgs = "-noeac -fromfl=be -fltoken=81e9e7f9faf320h1h7habd89 -frombe";
                if (client == "11.30")
                    clientArgs = "-noeac -fromfl=be -fltoken=04d45666aa73787c83843e12 -frombe";
                if (client == "11.31")
                    clientArgs = "-noeac -fromfl=be -fltoken=04d45666aa73787c83843e12 -frombe";
                if (client == "11.40")
                    clientArgs = "-noeac -fromfl=be -fltoken=gcf8i3i1i30a1912gc2be8b2 -frombe";
                if (client == "11.50")
                    clientArgs = "-noeac -fromfl=be -fltoken=65aci08888919949a4a65c37 -frombe";
                //season12
                if (client == "12.00")
                    clientArgs = "-noeac -fromfl=be -fltoken=e1ebf8fcg3gdgbi33704c593 -frombe";
                if (client == "12.10")
                    clientArgs = "-noeac -fromfl=be -fltoken=d5995d5a70b578808c9c4406 -frombe";
                if (client == "12.20")
                    clientArgs = "-noeac -fromfl=be -fltoken=f0gbgb11h8hc050afdd4dbcd -frombe";
                if (client == "12.21")
                    clientArgs = "-noeac -fromfl=be -fltoken=f0gbgb11h8hc050afdd4dbcd -frombe";
                if (client == "12.30")
                    clientArgs = "-noeac -fromfl=be -fltoken=d284d5dae8fb3b1bg8h2b168 -frombe";
                if (client == "12.40")
                    clientArgs = "-noeac -fromfl=be -fltoken=2a3038364c5894c566b224gd -frombe";
                if (client == "12.41")
                    clientArgs = "-noeac -fromfl=be -fltoken=2a3038364c5894c566b224gd -frombe";
                if (client == "12.50")
                    clientArgs = "-noeac -fromfl=be -fltoken=bc37d3cd49e0e6f818g1a250 -frombe";
                if (client == "12.60")
                    clientArgs = "-noeac -fromfl=be -fltoken=b76c62d5e3e43afdf2g4a564 -frombe";
                if (client == "12.61")
                    clientArgs = "-noeac -fromfl=be -fltoken=b76c62d5e3e43afdf2g4a564 -frombe";
                //season13
                if (client == "13.00")
                    clientArgs = "-noeac -fromfl=be -fltoken=6175bc888b9115a1a6b55c41 -frombe";
                if (client == "13.20")
                    clientArgs = "-noeac -fromfl=be -fltoken=529c77a4b7b792c9cddd8487 -frombe";
                if (client == "13.30")
                    clientArgs = "-noeac -fromfl=be -fltoken=5365b1ea7478878a9aa04908 -frombe";
                if (client == "13.40")
                    clientArgs = "-noeac -fromfl=be -fltoken=h70a0bga1b1d2a31ha17fcf2 -frombe";
                //season14
                if (client == "14.00")
                    clientArgs = "-noeac -fromfl=be -fltoken=9398aa74bbc738d90c938852 -frombe";
                if (client == "14.10")
                    clientArgs = "-noeac -fromfl=be -fltoken=2b35gbhaha41020b1614dcd8 -frombe";
                if (client == "14.20")
                    clientArgs = "-noeac -fromfl=be -fltoken=40h559576073746c86863826 -frombe";
                if (client == "14.30")
                    clientArgs = "-noeac -fromfl=be -fltoken=c80cdde4f2f32d13h3hab9ba -frombe";
                if (client == "14.40")
                    clientArgs = "-noeac -fromfl=be -fltoken=595d6ab25588cc8b98964E3a -frombe";
                if (client == "14.50")
                    clientArgs = "-noeac -fromfl=be -fltoken=g22ahaha002809212124e3ab -frombe";
                if (client == "14.60")
                    clientArgs = "-noeac -fromfl=be -fltoken=c57a7d85849294a87ab6610b -frombe";
                //season15
                if (client == "15.00")
                    clientArgs = "-noeac -fromfl=be -fltoken=52cbdae5e5f6f7gd2bh4b3b9 -frombe";
                if (client == "15.10")
                    clientArgs = "-noeac -fromfl=be -fltoken=bcb6c8d1d85200f3f9g8a285 -frombe";
                if (client == "15.20")
                    clientArgs = "-noeac -fromfl=be -fltoken=a6hdc5c353d2e2ea02f39654 -frombe";
                if (client == "15.21")
                    clientArgs = "-noeac -fromfl=be -fltoken=a6hdc5c353d2e2ea02f39654 -frombe";
                if (client == "15.30")
                    clientArgs = "-noeac -fromfl=be -fltoken=g9h643h90305g81d572de9a6 -frombe";
                if (client == "15.40")
                    clientArgs = "-noeac -fromfl=be -fltoken=c4c13cd6e9h422f9g91aa88a -frombe";
                if (client == "15.50")
                    clientArgs = "-noeac -fromfl=be -fltoken=4bg9h3i0i3030921f531e3c1 -frombe";
                //season16
                if (client == "16.00")
                    clientArgs = "-noeac -fromfl=be -fltoken=50b06570788bda9197a24F46 -frombe";
                if (client == "16.10")
                    clientArgs = "-noeac -fromfl=be -fltoken=acb178bacaca45e479f39849 -frombe";
                if (client == "16.20")
                    clientArgs = "-noeac -fromfl=be -fltoken=44339658c56872708b8d3a3c -frombe";
                if (client == "16.30")
                    clientArgs = "-noeac -fromfl=be -fltoken=c4c4d4d80de43af5f96da572 -frombe";
                if (client == "16.40")
                    clientArgs = "-noeac -fromfl=be -fltoken=hb01030779ec30ed3746f9g7 -frombe";
                if (client == "16.50")
                    clientArgs = "-noeac -fromfl=be -fltoken=64c47c7c9ci39995abac5901 -frombe";
                //season17
                if (client == "17.00")
                    clientArgs = "-noeac -fromfl=be -fltoken=4b976563b7e0768a8c93422c -frombe";
                if (client == "17.10")
                    clientArgs = "-noeac -fromfl=be -fltoken=c0cb77dbe4e21cf2g0gdaC74 -frombe";
                if (client == "17.20")
                    clientArgs = "-noeac -fromfl=be -fltoken=5360b1637173878a5a9a4938 -frombe";
                if (client == "17.21")
                    clientArgs = "-noeac -fromfl=be -fltoken=5360b1637173878a5a9a4938 -frombe";
                if (client == "17.30")
                    clientArgs = "-noeac -fromfl=be -fltoken=05e31d1bfd753044424b04h8 -frombe";
                if (client == "17.40")
                    clientArgs = "-noeac -fromfl=be -fltoken=7c818d90989664a665c76A2c -frombe";
                if (client == "17.50")
                    clientArgs = "-noeac -fromfl=be -fltoken=d9e80017f8g7gch1i306bea9 -frombe";
                //season18
                if (client == "18.00")
                    clientArgs = "-noeac -fromfl=be -fltoken=h53c08080b991b333338f3g7 -frombe";
                if (client == "18.10")
                    clientArgs = "-noeac -fromfl=be -fltoken=222832424652963a5ab81eh9 -frombe";
                if (client == "18.20")
                    clientArgs = "-noeac -fromfl=be -fltoken=d5a0e0f224g3h1hb43i2bfbb -frombe";
                if (client == "18.21")
                    clientArgs = "-noeac -fromfl=be -fltoken=d5a0e0f224g3h1hb43i2bfbb -frombe";
                if (client == "18.30")
                    clientArgs = "-noeac -fromfl=be -fltoken=h9033a110d161ch03341f1bc -frombe";
                if (client == "18.40")
                    clientArgs = "-noeac -fromfl=be -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiNThjZTBmM2NmYWI2NDE4OWFlOTM3ZGM0Y2M1ZGI5ZTUiLCJnZW5lcmF0ZWQiOjE2NjI0Njc2MzcsImNhbGRlcmFHdWlkIjoiZDc4NDFjMzMtZjg3Yy00ZmIwLTkxZGUtZjUwN2E3YjdiOTE2IiwiYWNQcm92aWRlciI6IkJhdHRsRXllIiwibm90ZXMiOiIiLCJmYWxsYmFjayI6ZmFsc2V9.E2-t4sJqfgWlrJ_hIfl6cgFfRkJ16_aylQwVa4R5GA47pyNp650BKzvrnc5yraz83BWPwuZrPFZIxfXKgJ3UvQ -frombe";

                int newClient = Convert.ToInt32(client.Replace(".", null));
                if (newClient > 1899)
                {
                    clientArgs = "-noeac -fromfl=be -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiNThjZTBmM2NmYWI2NDE4OWFlOTM3ZGM0Y2M1ZGI5ZTUiLCJnZW5lcmF0ZWQiOjE2NjI0Njc2MzcsImNhbGRlcmFHdWlkIjoiZDc4NDFjMzMtZjg3Yy00ZmIwLTkxZGUtZjUwN2E3YjdiOTE2IiwiYWNQcm92aWRlciI6IkJhdHRsRXllIiwibm90ZXMiOiIiLCJmYWxsYmFjayI6ZmFsc2V9.E2-t4sJqfgWlrJ_hIfl6cgFfRkJ16_aylQwVa4R5GA47pyNp650BKzvrnc5yraz83BWPwuZrPFZIxfXKgJ3UvQ -frombe";
                }

                /***
                //season19
                if (client == "19.00")
                    clientArgs = "-noeac -fromfl=be -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiNThjZTBmM2NmYWI2NDE4OWFlOTM3ZGM0Y2M1ZGI5ZTUiLCJnZW5lcmF0ZWQiOjE2NjI0Njc2MzcsImNhbGRlcmFHdWlkIjoiZDc4NDFjMzMtZjg3Yy00ZmIwLTkxZGUtZjUwN2E3YjdiOTE2IiwiYWNQcm92aWRlciI6IkJhdHRsRXllIiwibm90ZXMiOiIiLCJmYWxsYmFjayI6ZmFsc2V9.E2-t4sJqfgWlrJ_hIfl6cgFfRkJ16_aylQwVa4R5GA47pyNp650BKzvrnc5yraz83BWPwuZrPFZIxfXKgJ3UvQ -frombe";
                if (client == "19.01")
                    clientArgs = "-noeac -fromfl=be -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiNThjZTBmM2NmYWI2NDE4OWFlOTM3ZGM0Y2M1ZGI5ZTUiLCJnZW5lcmF0ZWQiOjE2NjI0Njc2MzcsImNhbGRlcmFHdWlkIjoiZDc4NDFjMzMtZjg3Yy00ZmIwLTkxZGUtZjUwN2E3YjdiOTE2IiwiYWNQcm92aWRlciI6IkJhdHRsRXllIiwibm90ZXMiOiIiLCJmYWxsYmFjayI6ZmFsc2V9.E2-t4sJqfgWlrJ_hIfl6cgFfRkJ16_aylQwVa4R5GA47pyNp650BKzvrnc5yraz83BWPwuZrPFZIxfXKgJ3UvQ -frombe";
                if (client == "19.10")
                    clientArgs = "-noeac -fromfl=be -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiNThjZTBmM2NmYWI2NDE4OWFlOTM3ZGM0Y2M1ZGI5ZTUiLCJnZW5lcmF0ZWQiOjE2NjI0Njc2MzcsImNhbGRlcmFHdWlkIjoiZDc4NDFjMzMtZjg3Yy00ZmIwLTkxZGUtZjUwN2E3YjdiOTE2IiwiYWNQcm92aWRlciI6IkJhdHRsRXllIiwibm90ZXMiOiIiLCJmYWxsYmFjayI6ZmFsc2V9.E2-t4sJqfgWlrJ_hIfl6cgFfRkJ16_aylQwVa4R5GA47pyNp650BKzvrnc5yraz83BWPwuZrPFZIxfXKgJ3UvQ -frombe";
                if (client == "19.20")
                    clientArgs = "-noeac -fromfl=be -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiNThjZTBmM2NmYWI2NDE4OWFlOTM3ZGM0Y2M1ZGI5ZTUiLCJnZW5lcmF0ZWQiOjE2NjI0Njc2MzcsImNhbGRlcmFHdWlkIjoiZDc4NDFjMzMtZjg3Yy00ZmIwLTkxZGUtZjUwN2E3YjdiOTE2IiwiYWNQcm92aWRlciI6IkJhdHRsRXllIiwibm90ZXMiOiIiLCJmYWxsYmFjayI6ZmFsc2V9.E2-t4sJqfgWlrJ_hIfl6cgFfRkJ16_aylQwVa4R5GA47pyNp650BKzvrnc5yraz83BWPwuZrPFZIxfXKgJ3UvQ -frombe";
                if (client == "19.30")
                    clientArgs = "-noeac -fromfl=be -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiNThjZTBmM2NmYWI2NDE4OWFlOTM3ZGM0Y2M1ZGI5ZTUiLCJnZW5lcmF0ZWQiOjE2NjI0Njc2MzcsImNhbGRlcmFHdWlkIjoiZDc4NDFjMzMtZjg3Yy00ZmIwLTkxZGUtZjUwN2E3YjdiOTE2IiwiYWNQcm92aWRlciI6IkJhdHRsRXllIiwibm90ZXMiOiIiLCJmYWxsYmFjayI6ZmFsc2V9.E2-t4sJqfgWlrJ_hIfl6cgFfRkJ16_aylQwVa4R5GA47pyNp650BKzvrnc5yraz83BWPwuZrPFZIxfXKgJ3UvQ -frombe";
                if (client == "19.40")
                    clientArgs = "-noeac -fromfl=be -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiNThjZTBmM2NmYWI2NDE4OWFlOTM3ZGM0Y2M1ZGI5ZTUiLCJnZW5lcmF0ZWQiOjE2NjI0Njc2MzcsImNhbGRlcmFHdWlkIjoiZDc4NDFjMzMtZjg3Yy00ZmIwLTkxZGUtZjUwN2E3YjdiOTE2IiwiYWNQcm92aWRlciI6IkJhdHRsRXllIiwibm90ZXMiOiIiLCJmYWxsYmFjayI6ZmFsc2V9.E2-t4sJqfgWlrJ_hIfl6cgFfRkJ16_aylQwVa4R5GA47pyNp650BKzvrnc5yraz83BWPwuZrPFZIxfXKgJ3UvQ -frombe";
                //season20
                if (client == "20.00")
                    clientArgs = "-noeac -fromfl=be -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiNThjZTBmM2NmYWI2NDE4OWFlOTM3ZGM0Y2M1ZGI5ZTUiLCJnZW5lcmF0ZWQiOjE2NjI0Njc2MzcsImNhbGRlcmFHdWlkIjoiZDc4NDFjMzMtZjg3Yy00ZmIwLTkxZGUtZjUwN2E3YjdiOTE2IiwiYWNQcm92aWRlciI6IkJhdHRsRXllIiwibm90ZXMiOiIiLCJmYWxsYmFjayI6ZmFsc2V9.E2-t4sJqfgWlrJ_hIfl6cgFfRkJ16_aylQwVa4R5GA47pyNp650BKzvrnc5yraz83BWPwuZrPFZIxfXKgJ3UvQ -frombe";
                if (client == "20.10")
                    clientArgs = "-noeac -fromfl=be -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiNThjZTBmM2NmYWI2NDE4OWFlOTM3ZGM0Y2M1ZGI5ZTUiLCJnZW5lcmF0ZWQiOjE2NjI0Njc2MzcsImNhbGRlcmFHdWlkIjoiZDc4NDFjMzMtZjg3Yy00ZmIwLTkxZGUtZjUwN2E3YjdiOTE2IiwiYWNQcm92aWRlciI6IkJhdHRsRXllIiwibm90ZXMiOiIiLCJmYWxsYmFjayI6ZmFsc2V9.E2-t4sJqfgWlrJ_hIfl6cgFfRkJ16_aylQwVa4R5GA47pyNp650BKzvrnc5yraz83BWPwuZrPFZIxfXKgJ3UvQ -frombe";
                if (client == "20.20")
                    clientArgs = "-noeac -fromfl=be -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiNThjZTBmM2NmYWI2NDE4OWFlOTM3ZGM0Y2M1ZGI5ZTUiLCJnZW5lcmF0ZWQiOjE2NjI0Njc2MzcsImNhbGRlcmFHdWlkIjoiZDc4NDFjMzMtZjg3Yy00ZmIwLTkxZGUtZjUwN2E3YjdiOTE2IiwiYWNQcm92aWRlciI6IkJhdHRsRXllIiwibm90ZXMiOiIiLCJmYWxsYmFjayI6ZmFsc2V9.E2-t4sJqfgWlrJ_hIfl6cgFfRkJ16_aylQwVa4R5GA47pyNp650BKzvrnc5yraz83BWPwuZrPFZIxfXKgJ3UvQ -frombe";
                if (client == "20.30")
                    clientArgs = "-noeac -fromfl=be -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiNThjZTBmM2NmYWI2NDE4OWFlOTM3ZGM0Y2M1ZGI5ZTUiLCJnZW5lcmF0ZWQiOjE2NjI0Njc2MzcsImNhbGRlcmFHdWlkIjoiZDc4NDFjMzMtZjg3Yy00ZmIwLTkxZGUtZjUwN2E3YjdiOTE2IiwiYWNQcm92aWRlciI6IkJhdHRsRXllIiwibm90ZXMiOiIiLCJmYWxsYmFjayI6ZmFsc2V9.E2-t4sJqfgWlrJ_hIfl6cgFfRkJ16_aylQwVa4R5GA47pyNp650BKzvrnc5yraz83BWPwuZrPFZIxfXKgJ3UvQ -frombe";
                if (client == "20.40")
                    clientArgs = "-noeac -fromfl=be -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiNThjZTBmM2NmYWI2NDE4OWFlOTM3ZGM0Y2M1ZGI5ZTUiLCJnZW5lcmF0ZWQiOjE2NjI0Njc2MzcsImNhbGRlcmFHdWlkIjoiZDc4NDFjMzMtZjg3Yy00ZmIwLTkxZGUtZjUwN2E3YjdiOTE2IiwiYWNQcm92aWRlciI6IkJhdHRsRXllIiwibm90ZXMiOiIiLCJmYWxsYmFjayI6ZmFsc2V9.E2-t4sJqfgWlrJ_hIfl6cgFfRkJ16_aylQwVa4R5GA47pyNp650BKzvrnc5yraz83BWPwuZrPFZIxfXKgJ3UvQ -frombe";
                //season21
                if (client == "21.00")
                    clientArgs = "-noeac -fromfl=be -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiNThjZTBmM2NmYWI2NDE4OWFlOTM3ZGM0Y2M1ZGI5ZTUiLCJnZW5lcmF0ZWQiOjE2NjI0Njc2MzcsImNhbGRlcmFHdWlkIjoiZDc4NDFjMzMtZjg3Yy00ZmIwLTkxZGUtZjUwN2E3YjdiOTE2IiwiYWNQcm92aWRlciI6IkJhdHRsRXllIiwibm90ZXMiOiIiLCJmYWxsYmFjayI6ZmFsc2V9.E2-t4sJqfgWlrJ_hIfl6cgFfRkJ16_aylQwVa4R5GA47pyNp650BKzvrnc5yraz83BWPwuZrPFZIxfXKgJ3UvQ -frombe";
                if (client == "21.10")
                    clientArgs = "-noeac -fromfl=be -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiNThjZTBmM2NmYWI2NDE4OWFlOTM3ZGM0Y2M1ZGI5ZTUiLCJnZW5lcmF0ZWQiOjE2NjI0Njc2MzcsImNhbGRlcmFHdWlkIjoiZDc4NDFjMzMtZjg3Yy00ZmIwLTkxZGUtZjUwN2E3YjdiOTE2IiwiYWNQcm92aWRlciI6IkJhdHRsRXllIiwibm90ZXMiOiIiLCJmYWxsYmFjayI6ZmFsc2V9.E2-t4sJqfgWlrJ_hIfl6cgFfRkJ16_aylQwVa4R5GA47pyNp650BKzvrnc5yraz83BWPwuZrPFZIxfXKgJ3UvQ -frombe";
                if (client == "21.20")
                    clientArgs = "-noeac -fromfl=be -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiNThjZTBmM2NmYWI2NDE4OWFlOTM3ZGM0Y2M1ZGI5ZTUiLCJnZW5lcmF0ZWQiOjE2NjI0Njc2MzcsImNhbGRlcmFHdWlkIjoiZDc4NDFjMzMtZjg3Yy00ZmIwLTkxZGUtZjUwN2E3YjdiOTE2IiwiYWNQcm92aWRlciI6IkJhdHRsRXllIiwibm90ZXMiOiIiLCJmYWxsYmFjayI6ZmFsc2V9.E2-t4sJqfgWlrJ_hIfl6cgFfRkJ16_aylQwVa4R5GA47pyNp650BKzvrnc5yraz83BWPwuZrPFZIxfXKgJ3UvQ -frombe";
                if (client == "21.30")
                    clientArgs = "-noeac -fromfl=be -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiNThjZTBmM2NmYWI2NDE4OWFlOTM3ZGM0Y2M1ZGI5ZTUiLCJnZW5lcmF0ZWQiOjE2NjI0Njc2MzcsImNhbGRlcmFHdWlkIjoiZDc4NDFjMzMtZjg3Yy00ZmIwLTkxZGUtZjUwN2E3YjdiOTE2IiwiYWNQcm92aWRlciI6IkJhdHRsRXllIiwibm90ZXMiOiIiLCJmYWxsYmFjayI6ZmFsc2V9.E2-t4sJqfgWlrJ_hIfl6cgFfRkJ16_aylQwVa4R5GA47pyNp650BKzvrnc5yraz83BWPwuZrPFZIxfXKgJ3UvQ -frombe";
                if (client == "21.40")
                    clientArgs = "-noeac -fromfl=be -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiNThjZTBmM2NmYWI2NDE4OWFlOTM3ZGM0Y2M1ZGI5ZTUiLCJnZW5lcmF0ZWQiOjE2NjI0Njc2MzcsImNhbGRlcmFHdWlkIjoiZDc4NDFjMzMtZjg3Yy00ZmIwLTkxZGUtZjUwN2E3YjdiOTE2IiwiYWNQcm92aWRlciI6IkJhdHRsRXllIiwibm90ZXMiOiIiLCJmYWxsYmFjayI6ZmFsc2V9.E2-t4sJqfgWlrJ_hIfl6cgFfRkJ16_aylQwVa4R5GA47pyNp650BKzvrnc5yraz83BWPwuZrPFZIxfXKgJ3UvQ -frombe";
                if (client == "21.50")
                    clientArgs = "-noeac -fromfl=be -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiNThjZTBmM2NmYWI2NDE4OWFlOTM3ZGM0Y2M1ZGI5ZTUiLCJnZW5lcmF0ZWQiOjE2NjI0Njc2MzcsImNhbGRlcmFHdWlkIjoiZDc4NDFjMzMtZjg3Yy00ZmIwLTkxZGUtZjUwN2E3YjdiOTE2IiwiYWNQcm92aWRlciI6IkJhdHRsRXllIiwibm90ZXMiOiIiLCJmYWxsYmFjayI6ZmFsc2V9.E2-t4sJqfgWlrJ_hIfl6cgFfRkJ16_aylQwVa4R5GA47pyNp650BKzvrnc5yraz83BWPwuZrPFZIxfXKgJ3UvQ -frombe";
                if (client == "21.51")
                    clientArgs = "-noeac -fromfl=be -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiNThjZTBmM2NmYWI2NDE4OWFlOTM3ZGM0Y2M1ZGI5ZTUiLCJnZW5lcmF0ZWQiOjE2NjI0Njc2MzcsImNhbGRlcmFHdWlkIjoiZDc4NDFjMzMtZjg3Yy00ZmIwLTkxZGUtZjUwN2E3YjdiOTE2IiwiYWNQcm92aWRlciI6IkJhdHRsRXllIiwibm90ZXMiOiIiLCJmYWxsYmFjayI6ZmFsc2V9.E2-t4sJqfgWlrJ_hIfl6cgFfRkJ16_aylQwVa4R5GA47pyNp650BKzvrnc5yraz83BWPwuZrPFZIxfXKgJ3UvQ -frombe";
                //season22
                if (client == "22.00")
                    clientArgs = "-noeac -fromfl=be -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiNThjZTBmM2NmYWI2NDE4OWFlOTM3ZGM0Y2M1ZGI5ZTUiLCJnZW5lcmF0ZWQiOjE2NjI0Njc2MzcsImNhbGRlcmFHdWlkIjoiZDc4NDFjMzMtZjg3Yy00ZmIwLTkxZGUtZjUwN2E3YjdiOTE2IiwiYWNQcm92aWRlciI6IkJhdHRsRXllIiwibm90ZXMiOiIiLCJmYWxsYmFjayI6ZmFsc2V9.E2-t4sJqfgWlrJ_hIfl6cgFfRkJ16_aylQwVa4R5GA47pyNp650BKzvrnc5yraz83BWPwuZrPFZIxfXKgJ3UvQ -frombe";
                if (client == "22.10")
                    clientArgs = "-noeac -fromfl=be -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiNThjZTBmM2NmYWI2NDE4OWFlOTM3ZGM0Y2M1ZGI5ZTUiLCJnZW5lcmF0ZWQiOjE2NjI0Njc2MzcsImNhbGRlcmFHdWlkIjoiZDc4NDFjMzMtZjg3Yy00ZmIwLTkxZGUtZjUwN2E3YjdiOTE2IiwiYWNQcm92aWRlciI6IkJhdHRsRXllIiwibm90ZXMiOiIiLCJmYWxsYmFjayI6ZmFsc2V9.E2-t4sJqfgWlrJ_hIfl6cgFfRkJ16_aylQwVa4R5GA47pyNp650BKzvrnc5yraz83BWPwuZrPFZIxfXKgJ3UvQ -frombe";
                if (client == "22.20")
                    clientArgs = "-noeac -fromfl=be -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiNThjZTBmM2NmYWI2NDE4OWFlOTM3ZGM0Y2M1ZGI5ZTUiLCJnZW5lcmF0ZWQiOjE2NjI0Njc2MzcsImNhbGRlcmFHdWlkIjoiZDc4NDFjMzMtZjg3Yy00ZmIwLTkxZGUtZjUwN2E3YjdiOTE2IiwiYWNQcm92aWRlciI6IkJhdHRsRXllIiwibm90ZXMiOiIiLCJmYWxsYmFjayI6ZmFsc2V9.E2-t4sJqfgWlrJ_hIfl6cgFfRkJ16_aylQwVa4R5GA47pyNp650BKzvrnc5yraz83BWPwuZrPFZIxfXKgJ3UvQ -frombe";
                if (client == "22.30")
                    clientArgs = "-noeac -fromfl=be -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiNThjZTBmM2NmYWI2NDE4OWFlOTM3ZGM0Y2M1ZGI5ZTUiLCJnZW5lcmF0ZWQiOjE2NjI0Njc2MzcsImNhbGRlcmFHdWlkIjoiZDc4NDFjMzMtZjg3Yy00ZmIwLTkxZGUtZjUwN2E3YjdiOTE2IiwiYWNQcm92aWRlciI6IkJhdHRsRXllIiwibm90ZXMiOiIiLCJmYWxsYmFjayI6ZmFsc2V9.E2-t4sJqfgWlrJ_hIfl6cgFfRkJ16_aylQwVa4R5GA47pyNp650BKzvrnc5yraz83BWPwuZrPFZIxfXKgJ3UvQ -frombe";
                if (client == "22.40")
                    clientArgs = "-noeac -fromfl=be -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiNThjZTBmM2NmYWI2NDE4OWFlOTM3ZGM0Y2M1ZGI5ZTUiLCJnZW5lcmF0ZWQiOjE2NjI0Njc2MzcsImNhbGRlcmFHdWlkIjoiZDc4NDFjMzMtZjg3Yy00ZmIwLTkxZGUtZjUwN2E3YjdiOTE2IiwiYWNQcm92aWRlciI6IkJhdHRsRXllIiwibm90ZXMiOiIiLCJmYWxsYmFjayI6ZmFsc2V9.E2-t4sJqfgWlrJ_hIfl6cgFfRkJ16_aylQwVa4R5GA47pyNp650BKzvrnc5yraz83BWPwuZrPFZIxfXKgJ3UvQ -frombe";
                ***/
            }

            if (type == "EasyAntiCheat")
            {
                //Season1&2
                if (client == "Cert")
                    clientArgs = "-nobe";
                if (client == "Live")
                    clientArgs = "-nobe";
                if (client == "2.2.0")
                    clientArgs = "-nobe";
                if (client == "2.3.0")
                    clientArgs = "-nobe";
                if (client == "2.3.2")
                    clientArgs = "-nobe";
                if (client == "2.4.0")
                    clientArgs = "-nobe";
                if (client == "2.4.2")
                    clientArgs = "-nobe";
                if (client == "2.4.x")
                    clientArgs = "-nobe";
                if (client == "2.5")
                    clientArgs = "-nobe";
                //Season3
                if (client == "3.0.0")
                    clientArgs = "-nobe";
                if (client == "3.1")
                    clientArgs = "-nobe";
                if (client == "3.2")
                    clientArgs = "-nobe";
                if (client == "3.3")
                    clientArgs = "-nobe";
                if (client == "3.4")
                    clientArgs = "-nobe";
                if (client == "3.5")
                    clientArgs = "-nobe";
                if (client == "3.6")
                    clientArgs = "-nobe";
                //season4
                if (client == "4.0")
                    clientArgs = "-nobe";
                if (client == "4.1")
                    clientArgs = "-nobe";
                if (client == "4.2")
                    clientArgs = "-nobe";
                if (client == "4.3")
                    clientArgs = "-nobe";
                if (client == "4.4")
                    clientArgs = "-nobe";
                if (client == "4.4.x")
                    clientArgs = "-nobe";
                if (client == "4.5")
                    clientArgs = "-nobe";
                //season5
                if (client == "5.0")
                    clientArgs = "-nobe";
                if (client == "5.10")
                    clientArgs = "-nobe";
                if (client == "5.20")
                    clientArgs = "-nobe -fromfl=eac";
                if (client == "5.21")
                    clientArgs = "-nobe -fromfl=eac";
                if (client == "5.30")
                    clientArgs = "-nobe -fromfl=eac";
                if (client == "5.40")
                    clientArgs = "-nobe -fromfl=eac";
                if (client == "5.41")
                    clientArgs = "-nobe -fromfl=eac";
                //season6
                if (client == "6.00")
                    clientArgs = "-nobe -fromfl=eac";
                if (client == "6.01")
                    clientArgs = "-nobe -fromfl=eac";
                if (client == "6.02")
                    clientArgs = "-nobe -fromfl=eac";
                if (client == "6.02")
                    clientArgs = "-nobe -fromfl=eac";
                if (client == "6.10")
                    clientArgs = "-nobe -fromfl=eac -fltoken=8682a0abb2b3ee86d8c2bc403b372f59626d0609700108131a5b5b443c4eb4beada99a99f6808883fbeaa6d1d1decec835777729";
                if (client == "6.20")
                    clientArgs = "-nobe -fromfl=eac -fltoken=858da0abb2b3ee86d8c2bc403b372f59626d0609700108131a5b5b443c4eb4beada99a99f6808883fbeaa6d1d189909b6077717810121e";
                if (client == "6.21")
                    clientArgs = "-nobe -fromfl=eac -fltoken=858da0abb2b3ee86d8c2bc403b372f59626d0609700108131a5b5b443c4eb4beada99a99f6808883fbeaa6d1d189909b6077717810121e";
                if (client == "6.22")
                    clientArgs = "-nobe -fromfl=eac -fltoken=858da0abb2b3ee86d8c2bc403b372f59626d0609700108131a5b5b443c4eb4beada99a99f6808883fbeaa6d1d189909b6077717810121e";
                if (client == "6.30")
                    clientArgs = "-nobe -fromfl=eac -fltoken=8483a0abb2b3ee86d8c2bc403b372f59626d0609700108131a5b5b443c4eb4beada99a99f6808883fbeaa6d1d18a929b6077257f10441e";
                if (client == "6.31")
                    clientArgs = "-nobe -fromfl=eac -fltoken=8483a0abb2b3ee86d8c2bc403b372f59626d0609700108131a5b5b443c4eb4beada99a99f6808883fbeaa6d1d18a929b6077257f10441e";
                //season7
                if (client == "7.00")
                    clientArgs = "-nobe -fromfl=eac -fltoken=868ba0abb2b3ee86d8c2bc403b372f59626d0609700108131a5b5b443c4eb4beada99a99f6808883fbeaa6d1d189909b6077242810441e";
                if (client == "7.01")
                    clientArgs = "-nobe -fromfl=eac -fltoken=868ba0abb2b3ee86d8c2bc403b372f59626d0609700108131a5b5b443c4eb4beada99a99f6808883fbeaa6d1d189909b6077242810441e";
                if (client == "7.10")
                    clientArgs = "-nobe -fromfl=eac -fltoken=";
                if (client == "7.20")
                    clientArgs = "-nobe -fromfl=eac -fltoken=";
                if (client == "7.30")
                    clientArgs = "-nobe -fromfl=eac -fltoken=72bd8be891999da578b9643a";
                if (client == "7.40")
                    clientArgs = "-nobe -fromfl=eac -fltoken=1d29g022h4h5050906g9d7b6";
                //season8
                if (client == "8.00")
                    clientArgs = "-nobe -fromfl=eac -fltoken=575862a9847575858c8c4418";
                if (client == "8.01")
                    clientArgs = "-nobe -fromfl=eac -fltoken=575862a9847575858c8c4418";
                if (client == "8.10")
                    clientArgs = "-nobe -fromfl=eac -fltoken=";
                if (client == "8.11")
                    clientArgs = "-nobe -fromfl=eac -fltoken=";
                if (client == "8.20")
                    clientArgs = "-nobe -fromfl=eac -fltoken=b974d2d6d9dce4ecf0g1a385";
                if (client == "8.30")
                    clientArgs = "-nobe -fromfl=eac -fltoken=2226g567h0i0ha020313d2b1";
                if (client == "8.40")
                    clientArgs = "-nobe -fromfl=eac -fltoken=8994f5acac5dbcc159ca7cd6";
                if (client == "8.50")
                    clientArgs = "-nobe -fromfl=eac -fltoken=4d666a6cba208788919d4Cg0";
                if (client == "8.51")
                    clientArgs = "-nobe -fromfl=eac -fltoken=4d666a6cba208788919d4Cg0";
                //season9
                if (client == "9.00")
                    clientArgs = "-nobe -fromfl=eac -fltoken=0903101217273437h6440042";
                if (client == "9.01")
                    clientArgs = "-nobe -fromfl=eac -fltoken=0903101217273437h6440042";
                if (client == "9.10")
                    clientArgs = "-nobe -fromfl=eac -fltoken=d5c8a09aa5b1bab75ad077c1";
                if (client == "9.20")
                    clientArgs = "-nobe -fromfl=eac -fltoken=h08336393d494d5d64722200";
                if (client == "9.21")
                    clientArgs = "-nobe -fromfl=eac -fltoken=h08336393d494d5d64722200";
                if (client == "9.30")
                    clientArgs = "-nobe -fromfl=eac -fltoken=1af0g2g0h7b305040c19d45c";
                if (client == "9.40")
                    clientArgs = "-nobe -fromfl=eac -fltoken=b1bcbad787bde9f1f5f99fa4";
                if (client == "9.41")
                    clientArgs = "-nobe -fromfl=eac -fltoken=b1bcbad787bde9f1f5f99fa4";
                //season10
                if (client == "10.0")
                    clientArgs = "-nobe -fromfl=eac -fltoken=6dab8383579a04abacc565e0";
                if (client == "10.10")
                    clientArgs = "-nobe -fromfl=eac -fltoken=hbi2hc06dah41c283235f04c";
                if (client == "10.20")
                    clientArgs = "-nobe -fromfl=eac -fltoken=a1bdab73c4bbd0d50de489b8";
                if (client == "10.30")
                    clientArgs = "-nobe -fromfl=eac -fltoken=g5gah6i3hae4111d1b24e160";
                if (client == "10.31")
                    clientArgs = "-nobe -fromfl=eac -fltoken=g5gah6i3hae4111d1b24e160";
                if (client == "10.40")
                    clientArgs = "-nobe -fromfl=eac -fltoken=8bdba2a4a6c3c4c88bd87fd2";
                //season11
                if (client == "11.00")
                    clientArgs = "-nobe -fromfl=eac -fltoken=46da55556b606d79d8893ah5";
                if (client == "11.01")
                    clientArgs = "-nobe -fromfl=eac -fltoken=46da55556b606d79d8893ah5";
                if (client == "11.10")
                    clientArgs = "-nobe -fromfl=eac -fltoken=b2f1ba5cd7cae3e420f598a5";
                if (client == "11.11")
                    clientArgs = "-nobe -fromfl=eac -fltoken=b2f1ba5cd7cae3e420f598a5";
                if (client == "11.20")
                    clientArgs = "-nobe -fromfl=eac -fltoken=81e9e7f9faf320h1h7habd89";
                if (client == "11.21")
                    clientArgs = "-nobe -fromfl=eac -fltoken=81e9e7f9faf320h1h7habd89";
                if (client == "11.30")
                    clientArgs = "-nobe -fromfl=eac -fltoken=04d45666aa73787c83843e12";
                if (client == "11.31")
                    clientArgs = "-nobe -fromfl=eac -fltoken=04d45666aa73787c83843e12";
                if (client == "11.40")
                    clientArgs = "-nobe -fromfl=eac -fltoken=gcf8i3i1i30a1912gc2be8b2";
                if (client == "11.50")
                    clientArgs = "-nobe -fromfl=eac -fltoken=65aci08888919949a4a65c37";
                //season12
                if (client == "12.00")
                    clientArgs = "-nobe -fromfl=eac -fltoken=e1ebf8fcg3gdgbi33704c593";
                if (client == "12.10")
                    clientArgs = "-nobe -fromfl=eac -fltoken=d5995d5a70b578808c9c4406";
                if (client == "12.20")
                    clientArgs = "-nobe -fromfl=eac -fltoken=f0gbgb11h8hc050afdd4dbcd";
                if (client == "12.21")
                    clientArgs = "-nobe -fromfl=eac -fltoken=f0gbgb11h8hc050afdd4dbcd";
                if (client == "12.30")
                    clientArgs = "-nobe -fromfl=eac -fltoken=d284d5dae8fb3b1bg8h2b168";
                if (client == "12.40")
                    clientArgs = "-nobe -fromfl=eac -fltoken=2a3038364c5894c566b224gd";
                if (client == "12.41")
                    clientArgs = "-nobe -fromfl=eac -fltoken=2a3038364c5894c566b224gd";
                if (client == "12.50")
                    clientArgs = "-nobe -fromfl=eac -fltoken=bc37d3cd49e0e6f818g1a250";
                if (client == "12.60")
                    clientArgs = "-nobe -fromfl=eac -fltoken=b76c62d5e3e43afdf2g4a564";
                if (client == "12.61")
                    clientArgs = "-nobe -fromfl=eac -fltoken=b76c62d5e3e43afdf2g4a564";
                //season13
                if (client == "13.00")
                    clientArgs = "-nobe -fromfl=eac -fltoken=6175bc888b9115a1a6b55c41";
                if (client == "13.20")
                    clientArgs = "-nobe -fromfl=eac -fltoken=529c77a4b7b792c9cddd8487";
                if (client == "13.30")
                    clientArgs = "-nobe -fromfl=eac -fltoken=5365b1ea7478878a9aa04908";
                if (client == "13.40")
                    clientArgs = "-nobe -fromfl=eac -fltoken=h70a0bga1b1d2a31ha17fcf2";
                //season14
                if (client == "14.00")
                    clientArgs = "-nobe -fromfl=eac -fltoken=9398aa74bbc738d90c938852";
                if (client == "14.10")
                    clientArgs = "-nobe -fromfl=eac -fltoken=2b35gbhaha41020b1614dcd8";
                if (client == "14.20")
                    clientArgs = "-nobe -fromfl=eac -fltoken=40h559576073746c86863826";
                if (client == "14.30")
                    clientArgs = "-nobe -fromfl=eac -fltoken=c80cdde4f2f32d13h3hab9ba";
                if (client == "14.40")
                    clientArgs = "-nobe -fromfl=eac -fltoken=595d6ab25588cc8b98964E3a";
                if (client == "14.50")
                    clientArgs = "-nobe -fromfl=eac -fltoken=g22ahaha002809212124e3ab";
                if (client == "14.60")
                    clientArgs = "-nobe -fromfl=eac -fltoken=c57a7d85849294a87ab6610b";
                //season15
                if (client == "15.00")
                    clientArgs = "-nobe -fromfl=eac -fltoken=52cbdae5e5f6f7gd2bh4b3b9";
                if (client == "15.10")
                    clientArgs = "-nobe -fromfl=eac -fltoken=bcb6c8d1d85200f3f9g8a285";
                if (client == "15.20")
                    clientArgs = "-nobe -fromfl=eac -fltoken=a6hdc5c353d2e2ea02f39654";
                if (client == "15.21")
                    clientArgs = "-nobe -fromfl=eac -fltoken=a6hdc5c353d2e2ea02f39654";
                if (client == "15.30")
                    clientArgs = "-nobe -fromfl=eac -fltoken=g9h643h90305g81d572de9a6";
                if (client == "15.40")
                    clientArgs = "-nobe -fromfl=eac -fltoken=c4c13cd6e9h422f9g91aa88a";
                if (client == "15.50")
                    clientArgs = "-nobe -fromfl=eac -fltoken=4bg9h3i0i3030921f531e3c1";
                //season16
                if (client == "16.00")
                    clientArgs = "-nobe -fromfl=eac -fltoken=50b06570788bda9197a24F46";
                if (client == "16.10")
                    clientArgs = "-nobe -fromfl=eac -fltoken=acb178bacaca45e479f39849";
                if (client == "16.20")
                    clientArgs = "-nobe -fromfl=eac -fltoken=44339658c56872708b8d3a3c";
                if (client == "16.30")
                    clientArgs = "-nobe -fromfl=eac -fltoken=c4c4d4d80de43af5f96da572";
                if (client == "16.40")
                    clientArgs = "-nobe -fromfl=eac -fltoken=hb01030779ec30ed3746f9g7";
                if (client == "16.50")
                    clientArgs = "-nobe -fromfl=eac -fltoken=64c47c7c9ci39995abac5901";
                //season17
                if (client == "17.00")
                    clientArgs = "-nobe -fromfl=eac -fltoken=4b976563b7e0768a8c93422c";
                if (client == "17.10")
                    clientArgs = "-nobe -fromfl=eac -fltoken=c0cb77dbe4e21cf2g0gdaC74";
                if (client == "17.20")
                    clientArgs = "-nobe -fromfl=eac -fltoken=5360b1637173878a5a9a4938";
                if (client == "17.21")
                    clientArgs = "-nobe -fromfl=eac -fltoken=5360b1637173878a5a9a4938";
                if (client == "17.30")
                    clientArgs = "-nobe -fromfl=eac -fltoken=05e31d1bfd753044424b04h8";
                if (client == "17.40")
                    clientArgs = "-nobe -fromfl=eac -fltoken=7c818d90989664a665c76A2c";
                if (client == "17.50")
                    clientArgs = "-nobe -fromfl=eac -fltoken=d9e80017f8g7gch1i306bea9";
                //season18
                if (client == "18.00")
                    clientArgs = "-nobe -fromfl=eac -fltoken=h53c08080b991b333338f3g7";
                if (client == "18.10")
                    clientArgs = "-nobe -fromfl=eac -fltoken=222832424652963a5ab81eh9";
                if (client == "18.20")
                    clientArgs = "-nobe -fromfl=eac -fltoken=d5a0e0f224g3h1hb43i2bfbb";
                if (client == "18.21")
                    clientArgs = "-nobe -fromfl=eac -fltoken=d5a0e0f224g3h1hb43i2bfbb";
                if (client == "18.30")
                    clientArgs = "-nobe -fromfl=eac -fltoken=h9033a110d161ch03341f1bc";
                if (client == "18.40")
                    clientArgs = "-nobe -fromfl=eac -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiNThjZTBmM2NmYWI2NDE4OWFlOTM3ZGM0Y2M1ZGI5ZTUiLCJnZW5lcmF0ZWQiOjE2NjIzNzA3NTcsImNhbGRlcmFHdWlkIjoiZjVhNDVmYzYtY2ZmZC00ZTQzLTgxYmEtM2RkNDZjYzMwZjQwIiwiYWNQcm92aWRlciI6IkVhc3lBbnRpQ2hlYXQiLCJub3RlcyI6IiIsImZhbGxiYWNrIjpmYWxzZX0.9RDOJKqa_54-_TlDdgBUv5m9IGxcQmVOcnmha-oUze5UPT5tvyS81phlmbhrSG4Sr9XCPOpVaOnLvOB3xc7mFA";

                int newClient = Convert.ToInt32(client.Replace(".", null));
                if (newClient > 1899)
                {
                    clientArgs = "-nobe -fromfl=eac -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiNThjZTBmM2NmYWI2NDE4OWFlOTM3ZGM0Y2M1ZGI5ZTUiLCJnZW5lcmF0ZWQiOjE2NjIzNzA3NTcsImNhbGRlcmFHdWlkIjoiZjVhNDVmYzYtY2ZmZC00ZTQzLTgxYmEtM2RkNDZjYzMwZjQwIiwiYWNQcm92aWRlciI6IkVhc3lBbnRpQ2hlYXQiLCJub3RlcyI6IiIsImZhbGxiYWNrIjpmYWxzZX0.9RDOJKqa_54-_TlDdgBUv5m9IGxcQmVOcnmha-oUze5UPT5tvyS81phlmbhrSG4Sr9XCPOpVaOnLvOB3xc7mFA";
                }

                /***
                //season19
                if (client == "19.00")
                    clientArgs = "-nobe -fromfl=eac -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiNThjZTBmM2NmYWI2NDE4OWFlOTM3ZGM0Y2M1ZGI5ZTUiLCJnZW5lcmF0ZWQiOjE2NjIzNzA3NTcsImNhbGRlcmFHdWlkIjoiZjVhNDVmYzYtY2ZmZC00ZTQzLTgxYmEtM2RkNDZjYzMwZjQwIiwiYWNQcm92aWRlciI6IkVhc3lBbnRpQ2hlYXQiLCJub3RlcyI6IiIsImZhbGxiYWNrIjpmYWxzZX0.9RDOJKqa_54-_TlDdgBUv5m9IGxcQmVOcnmha-oUze5UPT5tvyS81phlmbhrSG4Sr9XCPOpVaOnLvOB3xc7mFA";
                if (client == "19.01")
                    clientArgs = "-nobe -fromfl=eac -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiNThjZTBmM2NmYWI2NDE4OWFlOTM3ZGM0Y2M1ZGI5ZTUiLCJnZW5lcmF0ZWQiOjE2NjIzNzA3NTcsImNhbGRlcmFHdWlkIjoiZjVhNDVmYzYtY2ZmZC00ZTQzLTgxYmEtM2RkNDZjYzMwZjQwIiwiYWNQcm92aWRlciI6IkVhc3lBbnRpQ2hlYXQiLCJub3RlcyI6IiIsImZhbGxiYWNrIjpmYWxzZX0.9RDOJKqa_54-_TlDdgBUv5m9IGxcQmVOcnmha-oUze5UPT5tvyS81phlmbhrSG4Sr9XCPOpVaOnLvOB3xc7mFA";
                if (client == "19.10")
                    clientArgs = "-nobe -fromfl=eac -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiNThjZTBmM2NmYWI2NDE4OWFlOTM3ZGM0Y2M1ZGI5ZTUiLCJnZW5lcmF0ZWQiOjE2NjIzNzA3NTcsImNhbGRlcmFHdWlkIjoiZjVhNDVmYzYtY2ZmZC00ZTQzLTgxYmEtM2RkNDZjYzMwZjQwIiwiYWNQcm92aWRlciI6IkVhc3lBbnRpQ2hlYXQiLCJub3RlcyI6IiIsImZhbGxiYWNrIjpmYWxzZX0.9RDOJKqa_54-_TlDdgBUv5m9IGxcQmVOcnmha-oUze5UPT5tvyS81phlmbhrSG4Sr9XCPOpVaOnLvOB3xc7mFA";
                if (client == "19.20")
                    clientArgs = "-nobe -fromfl=eac -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiNThjZTBmM2NmYWI2NDE4OWFlOTM3ZGM0Y2M1ZGI5ZTUiLCJnZW5lcmF0ZWQiOjE2NjIzNzA3NTcsImNhbGRlcmFHdWlkIjoiZjVhNDVmYzYtY2ZmZC00ZTQzLTgxYmEtM2RkNDZjYzMwZjQwIiwiYWNQcm92aWRlciI6IkVhc3lBbnRpQ2hlYXQiLCJub3RlcyI6IiIsImZhbGxiYWNrIjpmYWxzZX0.9RDOJKqa_54-_TlDdgBUv5m9IGxcQmVOcnmha-oUze5UPT5tvyS81phlmbhrSG4Sr9XCPOpVaOnLvOB3xc7mFA";
                if (client == "19.30")
                    clientArgs = "-nobe -fromfl=eac -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiNThjZTBmM2NmYWI2NDE4OWFlOTM3ZGM0Y2M1ZGI5ZTUiLCJnZW5lcmF0ZWQiOjE2NjIzNzA3NTcsImNhbGRlcmFHdWlkIjoiZjVhNDVmYzYtY2ZmZC00ZTQzLTgxYmEtM2RkNDZjYzMwZjQwIiwiYWNQcm92aWRlciI6IkVhc3lBbnRpQ2hlYXQiLCJub3RlcyI6IiIsImZhbGxiYWNrIjpmYWxzZX0.9RDOJKqa_54-_TlDdgBUv5m9IGxcQmVOcnmha-oUze5UPT5tvyS81phlmbhrSG4Sr9XCPOpVaOnLvOB3xc7mFA";
                if (client == "19.40")
                    clientArgs = "-nobe -fromfl=eac -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiNThjZTBmM2NmYWI2NDE4OWFlOTM3ZGM0Y2M1ZGI5ZTUiLCJnZW5lcmF0ZWQiOjE2NjIzNzA3NTcsImNhbGRlcmFHdWlkIjoiZjVhNDVmYzYtY2ZmZC00ZTQzLTgxYmEtM2RkNDZjYzMwZjQwIiwiYWNQcm92aWRlciI6IkVhc3lBbnRpQ2hlYXQiLCJub3RlcyI6IiIsImZhbGxiYWNrIjpmYWxzZX0.9RDOJKqa_54-_TlDdgBUv5m9IGxcQmVOcnmha-oUze5UPT5tvyS81phlmbhrSG4Sr9XCPOpVaOnLvOB3xc7mFA";
                //season20
                if (client == "20.00")
                    clientArgs = "-nobe -fromfl=eac -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiNThjZTBmM2NmYWI2NDE4OWFlOTM3ZGM0Y2M1ZGI5ZTUiLCJnZW5lcmF0ZWQiOjE2NjIzNzA3NTcsImNhbGRlcmFHdWlkIjoiZjVhNDVmYzYtY2ZmZC00ZTQzLTgxYmEtM2RkNDZjYzMwZjQwIiwiYWNQcm92aWRlciI6IkVhc3lBbnRpQ2hlYXQiLCJub3RlcyI6IiIsImZhbGxiYWNrIjpmYWxzZX0.9RDOJKqa_54-_TlDdgBUv5m9IGxcQmVOcnmha-oUze5UPT5tvyS81phlmbhrSG4Sr9XCPOpVaOnLvOB3xc7mFA";
                if (client == "20.10")
                    clientArgs = "-nobe -fromfl=eac -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiNThjZTBmM2NmYWI2NDE4OWFlOTM3ZGM0Y2M1ZGI5ZTUiLCJnZW5lcmF0ZWQiOjE2NjIzNzA3NTcsImNhbGRlcmFHdWlkIjoiZjVhNDVmYzYtY2ZmZC00ZTQzLTgxYmEtM2RkNDZjYzMwZjQwIiwiYWNQcm92aWRlciI6IkVhc3lBbnRpQ2hlYXQiLCJub3RlcyI6IiIsImZhbGxiYWNrIjpmYWxzZX0.9RDOJKqa_54-_TlDdgBUv5m9IGxcQmVOcnmha-oUze5UPT5tvyS81phlmbhrSG4Sr9XCPOpVaOnLvOB3xc7mFA";
                if (client == "20.20")
                    clientArgs = "-nobe -fromfl=eac -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiNThjZTBmM2NmYWI2NDE4OWFlOTM3ZGM0Y2M1ZGI5ZTUiLCJnZW5lcmF0ZWQiOjE2NjIzNzA3NTcsImNhbGRlcmFHdWlkIjoiZjVhNDVmYzYtY2ZmZC00ZTQzLTgxYmEtM2RkNDZjYzMwZjQwIiwiYWNQcm92aWRlciI6IkVhc3lBbnRpQ2hlYXQiLCJub3RlcyI6IiIsImZhbGxiYWNrIjpmYWxzZX0.9RDOJKqa_54-_TlDdgBUv5m9IGxcQmVOcnmha-oUze5UPT5tvyS81phlmbhrSG4Sr9XCPOpVaOnLvOB3xc7mFA";
                if (client == "20.30")
                    clientArgs = "-nobe -fromfl=eac -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiNThjZTBmM2NmYWI2NDE4OWFlOTM3ZGM0Y2M1ZGI5ZTUiLCJnZW5lcmF0ZWQiOjE2NjIzNzA3NTcsImNhbGRlcmFHdWlkIjoiZjVhNDVmYzYtY2ZmZC00ZTQzLTgxYmEtM2RkNDZjYzMwZjQwIiwiYWNQcm92aWRlciI6IkVhc3lBbnRpQ2hlYXQiLCJub3RlcyI6IiIsImZhbGxiYWNrIjpmYWxzZX0.9RDOJKqa_54-_TlDdgBUv5m9IGxcQmVOcnmha-oUze5UPT5tvyS81phlmbhrSG4Sr9XCPOpVaOnLvOB3xc7mFA";
                if (client == "20.40")
                    clientArgs = "-nobe -fromfl=eac -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiNThjZTBmM2NmYWI2NDE4OWFlOTM3ZGM0Y2M1ZGI5ZTUiLCJnZW5lcmF0ZWQiOjE2NjIzNzA3NTcsImNhbGRlcmFHdWlkIjoiZjVhNDVmYzYtY2ZmZC00ZTQzLTgxYmEtM2RkNDZjYzMwZjQwIiwiYWNQcm92aWRlciI6IkVhc3lBbnRpQ2hlYXQiLCJub3RlcyI6IiIsImZhbGxiYWNrIjpmYWxzZX0.9RDOJKqa_54-_TlDdgBUv5m9IGxcQmVOcnmha-oUze5UPT5tvyS81phlmbhrSG4Sr9XCPOpVaOnLvOB3xc7mFA";
                //season21
                if (client == "21.00")
                    clientArgs = "-nobe -fromfl=eac -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiNThjZTBmM2NmYWI2NDE4OWFlOTM3ZGM0Y2M1ZGI5ZTUiLCJnZW5lcmF0ZWQiOjE2NjIzNzA3NTcsImNhbGRlcmFHdWlkIjoiZjVhNDVmYzYtY2ZmZC00ZTQzLTgxYmEtM2RkNDZjYzMwZjQwIiwiYWNQcm92aWRlciI6IkVhc3lBbnRpQ2hlYXQiLCJub3RlcyI6IiIsImZhbGxiYWNrIjpmYWxzZX0.9RDOJKqa_54-_TlDdgBUv5m9IGxcQmVOcnmha-oUze5UPT5tvyS81phlmbhrSG4Sr9XCPOpVaOnLvOB3xc7mFA";
                if (client == "21.10")
                    clientArgs = "-nobe -fromfl=eac -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiNThjZTBmM2NmYWI2NDE4OWFlOTM3ZGM0Y2M1ZGI5ZTUiLCJnZW5lcmF0ZWQiOjE2NjIzNzA3NTcsImNhbGRlcmFHdWlkIjoiZjVhNDVmYzYtY2ZmZC00ZTQzLTgxYmEtM2RkNDZjYzMwZjQwIiwiYWNQcm92aWRlciI6IkVhc3lBbnRpQ2hlYXQiLCJub3RlcyI6IiIsImZhbGxiYWNrIjpmYWxzZX0.9RDOJKqa_54-_TlDdgBUv5m9IGxcQmVOcnmha-oUze5UPT5tvyS81phlmbhrSG4Sr9XCPOpVaOnLvOB3xc7mFA";
                if (client == "21.20")
                    clientArgs = "-nobe -fromfl=eac -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiNThjZTBmM2NmYWI2NDE4OWFlOTM3ZGM0Y2M1ZGI5ZTUiLCJnZW5lcmF0ZWQiOjE2NjIzNzA3NTcsImNhbGRlcmFHdWlkIjoiZjVhNDVmYzYtY2ZmZC00ZTQzLTgxYmEtM2RkNDZjYzMwZjQwIiwiYWNQcm92aWRlciI6IkVhc3lBbnRpQ2hlYXQiLCJub3RlcyI6IiIsImZhbGxiYWNrIjpmYWxzZX0.9RDOJKqa_54-_TlDdgBUv5m9IGxcQmVOcnmha-oUze5UPT5tvyS81phlmbhrSG4Sr9XCPOpVaOnLvOB3xc7mFA";
                if (client == "21.30")
                    clientArgs = "-nobe -fromfl=eac -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiNThjZTBmM2NmYWI2NDE4OWFlOTM3ZGM0Y2M1ZGI5ZTUiLCJnZW5lcmF0ZWQiOjE2NjIzNzA3NTcsImNhbGRlcmFHdWlkIjoiZjVhNDVmYzYtY2ZmZC00ZTQzLTgxYmEtM2RkNDZjYzMwZjQwIiwiYWNQcm92aWRlciI6IkVhc3lBbnRpQ2hlYXQiLCJub3RlcyI6IiIsImZhbGxiYWNrIjpmYWxzZX0.9RDOJKqa_54-_TlDdgBUv5m9IGxcQmVOcnmha-oUze5UPT5tvyS81phlmbhrSG4Sr9XCPOpVaOnLvOB3xc7mFA";
                if (client == "21.40")
                    clientArgs = "-nobe -fromfl=eac -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiNThjZTBmM2NmYWI2NDE4OWFlOTM3ZGM0Y2M1ZGI5ZTUiLCJnZW5lcmF0ZWQiOjE2NjIzNzA3NTcsImNhbGRlcmFHdWlkIjoiZjVhNDVmYzYtY2ZmZC00ZTQzLTgxYmEtM2RkNDZjYzMwZjQwIiwiYWNQcm92aWRlciI6IkVhc3lBbnRpQ2hlYXQiLCJub3RlcyI6IiIsImZhbGxiYWNrIjpmYWxzZX0.9RDOJKqa_54-_TlDdgBUv5m9IGxcQmVOcnmha-oUze5UPT5tvyS81phlmbhrSG4Sr9XCPOpVaOnLvOB3xc7mFA";
                if (client == "21.50")
                    clientArgs = "-nobe -fromfl=eac -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiNThjZTBmM2NmYWI2NDE4OWFlOTM3ZGM0Y2M1ZGI5ZTUiLCJnZW5lcmF0ZWQiOjE2NjIzNzA3NTcsImNhbGRlcmFHdWlkIjoiZjVhNDVmYzYtY2ZmZC00ZTQzLTgxYmEtM2RkNDZjYzMwZjQwIiwiYWNQcm92aWRlciI6IkVhc3lBbnRpQ2hlYXQiLCJub3RlcyI6IiIsImZhbGxiYWNrIjpmYWxzZX0.9RDOJKqa_54-_TlDdgBUv5m9IGxcQmVOcnmha-oUze5UPT5tvyS81phlmbhrSG4Sr9XCPOpVaOnLvOB3xc7mFA";
                if (client == "21.51")
                    clientArgs = "-nobe -fromfl=eac -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiNThjZTBmM2NmYWI2NDE4OWFlOTM3ZGM0Y2M1ZGI5ZTUiLCJnZW5lcmF0ZWQiOjE2NjIzNzA3NTcsImNhbGRlcmFHdWlkIjoiZjVhNDVmYzYtY2ZmZC00ZTQzLTgxYmEtM2RkNDZjYzMwZjQwIiwiYWNQcm92aWRlciI6IkVhc3lBbnRpQ2hlYXQiLCJub3RlcyI6IiIsImZhbGxiYWNrIjpmYWxzZX0.9RDOJKqa_54-_TlDdgBUv5m9IGxcQmVOcnmha-oUze5UPT5tvyS81phlmbhrSG4Sr9XCPOpVaOnLvOB3xc7mFA";
                //season22
                if (client == "22.00")
                    clientArgs = "-nobe -fromfl=eac -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiNThjZTBmM2NmYWI2NDE4OWFlOTM3ZGM0Y2M1ZGI5ZTUiLCJnZW5lcmF0ZWQiOjE2NjIzNzA3NTcsImNhbGRlcmFHdWlkIjoiZjVhNDVmYzYtY2ZmZC00ZTQzLTgxYmEtM2RkNDZjYzMwZjQwIiwiYWNQcm92aWRlciI6IkVhc3lBbnRpQ2hlYXQiLCJub3RlcyI6IiIsImZhbGxiYWNrIjpmYWxzZX0.9RDOJKqa_54-_TlDdgBUv5m9IGxcQmVOcnmha-oUze5UPT5tvyS81phlmbhrSG4Sr9XCPOpVaOnLvOB3xc7mFA";
                if (client == "22.10")
                    clientArgs = "-nobe -fromfl=eac -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiNThjZTBmM2NmYWI2NDE4OWFlOTM3ZGM0Y2M1ZGI5ZTUiLCJnZW5lcmF0ZWQiOjE2NjIzNzA3NTcsImNhbGRlcmFHdWlkIjoiZjVhNDVmYzYtY2ZmZC00ZTQzLTgxYmEtM2RkNDZjYzMwZjQwIiwiYWNQcm92aWRlciI6IkVhc3lBbnRpQ2hlYXQiLCJub3RlcyI6IiIsImZhbGxiYWNrIjpmYWxzZX0.9RDOJKqa_54-_TlDdgBUv5m9IGxcQmVOcnmha-oUze5UPT5tvyS81phlmbhrSG4Sr9XCPOpVaOnLvOB3xc7mFA";
                if (client == "22.20")
                    clientArgs = "-nobe -fromfl=eac -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiNThjZTBmM2NmYWI2NDE4OWFlOTM3ZGM0Y2M1ZGI5ZTUiLCJnZW5lcmF0ZWQiOjE2NjIzNzA3NTcsImNhbGRlcmFHdWlkIjoiZjVhNDVmYzYtY2ZmZC00ZTQzLTgxYmEtM2RkNDZjYzMwZjQwIiwiYWNQcm92aWRlciI6IkVhc3lBbnRpQ2hlYXQiLCJub3RlcyI6IiIsImZhbGxiYWNrIjpmYWxzZX0.9RDOJKqa_54-_TlDdgBUv5m9IGxcQmVOcnmha-oUze5UPT5tvyS81phlmbhrSG4Sr9XCPOpVaOnLvOB3xc7mFA";
                if (client == "22.30")
                    clientArgs = "-nobe -fromfl=eac -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiNThjZTBmM2NmYWI2NDE4OWFlOTM3ZGM0Y2M1ZGI5ZTUiLCJnZW5lcmF0ZWQiOjE2NjIzNzA3NTcsImNhbGRlcmFHdWlkIjoiZjVhNDVmYzYtY2ZmZC00ZTQzLTgxYmEtM2RkNDZjYzMwZjQwIiwiYWNQcm92aWRlciI6IkVhc3lBbnRpQ2hlYXQiLCJub3RlcyI6IiIsImZhbGxiYWNrIjpmYWxzZX0.9RDOJKqa_54-_TlDdgBUv5m9IGxcQmVOcnmha-oUze5UPT5tvyS81phlmbhrSG4Sr9XCPOpVaOnLvOB3xc7mFA";
                if (client == "22.40")
                    clientArgs = "-nobe -fromfl=eac -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiNThjZTBmM2NmYWI2NDE4OWFlOTM3ZGM0Y2M1ZGI5ZTUiLCJnZW5lcmF0ZWQiOjE2NjIzNzA3NTcsImNhbGRlcmFHdWlkIjoiZjVhNDVmYzYtY2ZmZC00ZTQzLTgxYmEtM2RkNDZjYzMwZjQwIiwiYWNQcm92aWRlciI6IkVhc3lBbnRpQ2hlYXQiLCJub3RlcyI6IiIsImZhbGxiYWNrIjpmYWxzZX0.9RDOJKqa_54-_TlDdgBUv5m9IGxcQmVOcnmha-oUze5UPT5tvyS81phlmbhrSG4Sr9XCPOpVaOnLvOB3xc7mFA";
                ***/
            }
            return clientArgs;
        }
    }
}
