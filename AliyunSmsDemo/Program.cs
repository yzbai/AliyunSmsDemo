using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Sms.Model.V20170525;
using System;

namespace AliyunSmsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //以下字段换成自己的
            string regionId = "cn-hangzhou";
            string accessKeyId = "xxxxxxxx";
            string accessKeySecret = "xxxxxxxxxxxxxxxxxxxxxxxx";
            string signName = "xxxxxxxxxx";
            string phoneNumbers = "15xxxxxxxxx";
            string templateCode = "SMS_73985016";
            string templateParam = "{\"code\":\"123456\", \"product\":\"MyProduct\"}";


            IClientProfile clientProfile = DefaultProfile.GetProfile(regionId, accessKeyId, accessKeySecret);
            DefaultProfile.AddEndpoint(regionId, regionId, "Dysmsapi", "dysmsapi.aliyuncs.com");

            IAcsClient acsClient = new DefaultAcsClient(clientProfile);

            SendSmsRequest request = new SendSmsRequest();

            request.SignName = signName;
            request.TemplateCode = templateCode;
            request.PhoneNumbers = phoneNumbers;
            request.TemplateParam = templateParam;

            try
            {
                SendSmsResponse response = acsClient.GetAcsResponse(request);
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
