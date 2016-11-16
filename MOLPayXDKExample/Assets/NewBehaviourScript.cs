﻿using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using MOLPayXDK;

public class NewBehaviourScript : MonoBehaviour
{
    MOLPay molpay = new MOLPay();

    void Start()
    {
        Dictionary<String, object> paymentDetails = new Dictionary<String, object>();
		paymentDetails.Add(MOLPay.mp_amount, "");
		paymentDetails.Add(MOLPay.mp_username, "");
		paymentDetails.Add(MOLPay.mp_password, "");
		paymentDetails.Add(MOLPay.mp_merchant_ID, "");
		paymentDetails.Add(MOLPay.mp_app_name, "");
		paymentDetails.Add(MOLPay.mp_verification_key, "");
		paymentDetails.Add(MOLPay.mp_order_ID, "");
		paymentDetails.Add(MOLPay.mp_currency, "MYR");
		paymentDetails.Add(MOLPay.mp_country, "MY");
		paymentDetails.Add(MOLPay.mp_channel, "");
		paymentDetails.Add(MOLPay.mp_bill_description, "");
		paymentDetails.Add(MOLPay.mp_bill_name, "");
		paymentDetails.Add(MOLPay.mp_bill_email, "");
		paymentDetails.Add(MOLPay.mp_bill_mobile, "");
        paymentDetails.Add(MOLPay.mp_channel_editing, false);
        paymentDetails.Add(MOLPay.mp_editing_enabled, false);
        //paymentDetails.Add(MOLPay.mp_is_escrow, "");
        //paymentDetails.Add(MOLPay.mp_transaction_id, "");
        //paymentDetails.Add(MOLPay.mp_request_type, "");
        //String[] binlock = new String[] { "", "" };
        //paymentDetails.Add(MOLPay.mp_bin_lock, binlock);
        //paymentDetails.Add(MOLPay.mp_bin_lock_err_msg, "");
#if UNITY_IOS
        //paymentDetails.Add(MOLPay.mp_custom_css_url, Application.streamingAssetsPath + "/custom.css");
#elif UNITY_ANDROID
        //paymentDetails.Add(MOLPay.mp_custom_css_url, "file:///android_asset/custom.css");
#endif
        //paymentDetails.Add(MOLPay.mp_preferred_token, "");
        //paymentDetails.Add(MOLPay.mp_tcctype, "");
        //paymentDetails.Add(MOLPay.mp_is_recurring, false);
        //paymentDetails.Add(MOLPay.mp_sandbox_mode, false);
        //String[] allowedChannels = new String[] { "credit", "credit3", null };
        //paymentDetails.Add(MOLPay.mp_allowed_channels, allowedChannels);
        //paymentDetails.Add(MOLPay.mp_express_mode, false);

        molpay.StartMolpay(paymentDetails, MolpayCallback);
    }

    void Update()
    {

    }

    public void Close()
    {
        molpay.CloseMolpay();
    }

    public void MolpayCallback(string transactionResult)
    {
        Debug.Log("MolpayCallback transactionResult = " + transactionResult);
    }
}