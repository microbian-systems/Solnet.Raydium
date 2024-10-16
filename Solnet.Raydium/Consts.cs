﻿using Solnet.Wallet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solnet.Raydium
{
    /// <summary>
    /// Collection of Raydium specific consts
    /// </summary>
    public class Consts
    {

        public const string STAKE_PROGRAM_ID = "EhhTKczWMGQt46ynNeRX1WfeagwwJd7ufHvCDjRxjo5Q";

        public const string STAKE_PROGRAM_ID_V4 = "CBuCnLe26faBpcBP2fktp4rp8abpcAnTWft6ZrP5Q4T";

        public const string STAKE_PROGRAM_ID_V5 = "9KEPoZmtHUrBbhWN1v1KWLMkkvwY6WLtAVUCPRtRjP4z";




        public const string LIQUIDITY_POOL_PROGRAM_ID_V4 = "675kPX9MHTjS2zt1qfr1NYHuzeLXfQM9H24wFSUt1Mp8";


        public const string RAYDIUM_SINGLE_SIDED_STAKING_POOL = "EhhTKczWMGQt46ynNeRX1WfeagwwJd7ufHvCDjRxjo5Q";





        /// <summary>
        /// The public key of the sysvar clock account.
        /// </summary>
        public static readonly PublicKey SYSVAR_CLOCK_PUBKEY = new("SysvarC1ock11111111111111111111111111111111");

    }
}
