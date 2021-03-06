/*
    This file is part of the iText (R) project.
    Copyright (c) 1998-2019 iText Group NV
    Authors: iText Software.

This program is free software; you can redistribute it and/or modify it under the terms of the GNU Affero General Public License version 3 as published by the Free Software Foundation with the addition of the following permission added to Section 15 as permitted in Section 7(a): FOR ANY PART OF THE COVERED WORK IN WHICH THE COPYRIGHT IS OWNED BY iText Group NV, iText Group NV DISCLAIMS THE WARRANTY OF NON INFRINGEMENT OF THIRD PARTY RIGHTS.

This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU Affero General Public License for more details.
You should have received a copy of the GNU Affero General Public License along with this program; if not, see http://www.gnu.org/licenses or write to the Free Software Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA, 02110-1301 USA, or download the license from the following URL:

http://itextpdf.com/terms-of-use/

The interactive user interfaces in modified source and object code versions of this program must display Appropriate Legal Notices, as required under Section 5 of the GNU Affero General Public License.

In accordance with Section 7(b) of the GNU Affero General Public License, a covered work must retain the producer line in every PDF that is created or manipulated using iText.

You can be released from the requirements of the license by purchasing a commercial license. Buying such a license is mandatory as soon as you develop commercial activities involving the iText software without disclosing the source code of your own applications.
These activities include: offering paid services to customers as an ASP, serving PDFs on the fly in a web application, shipping iText with a closed source product.

For more information, please contact iText Software Corp. at this address: sales@itextpdf.com */
using System;

namespace Org.BouncyCastle.Asn1.BC
{
	public abstract class BCObjectIdentifiers
	{
		// iso.org.dod.internet.private.enterprise.legion-of-the-bouncy-castle
		// 1.3.6.1.4.1.22554
		public static readonly DerObjectIdentifier bc = new DerObjectIdentifier("1.3.6.1.4.1.22554");

		// pbe(1) algorithms
		public static readonly DerObjectIdentifier bc_pbe = new DerObjectIdentifier(bc + ".1");

		// SHA-1(1)
		public static readonly DerObjectIdentifier bc_pbe_sha1 = new DerObjectIdentifier(bc_pbe + ".1");

		// SHA-2(2) . (SHA-256(1)|SHA-384(2)|SHA-512(3)|SHA-224(4))
		public static readonly DerObjectIdentifier bc_pbe_sha256 = new DerObjectIdentifier(bc_pbe + ".2.1");
		public static readonly DerObjectIdentifier bc_pbe_sha384 = new DerObjectIdentifier(bc_pbe + ".2.2");
		public static readonly DerObjectIdentifier bc_pbe_sha512 = new DerObjectIdentifier(bc_pbe + ".2.3");
		public static readonly DerObjectIdentifier bc_pbe_sha224 = new DerObjectIdentifier(bc_pbe + ".2.4");
		
		// PKCS-5(1)|PKCS-12(2)
		public static readonly DerObjectIdentifier bc_pbe_sha1_pkcs5 = new DerObjectIdentifier(bc_pbe_sha1 + ".1");
		public static readonly DerObjectIdentifier bc_pbe_sha1_pkcs12 = new DerObjectIdentifier(bc_pbe_sha1 + ".2");
		
		public static readonly DerObjectIdentifier bc_pbe_sha256_pkcs5 = new DerObjectIdentifier(bc_pbe_sha256 + ".1");
		public static readonly DerObjectIdentifier bc_pbe_sha256_pkcs12 = new DerObjectIdentifier(bc_pbe_sha256 + ".2");

		// AES(1) . (CBC-128(2)|CBC-192(22)|CBC-256(42))
		public static readonly DerObjectIdentifier bc_pbe_sha1_pkcs12_aes128_cbc = new DerObjectIdentifier(bc_pbe_sha1_pkcs12 + ".1.2");
		public static readonly DerObjectIdentifier bc_pbe_sha1_pkcs12_aes192_cbc = new DerObjectIdentifier(bc_pbe_sha1_pkcs12 + ".1.22");
		public static readonly DerObjectIdentifier bc_pbe_sha1_pkcs12_aes256_cbc = new DerObjectIdentifier(bc_pbe_sha1_pkcs12 + ".1.42");

		public static readonly DerObjectIdentifier bc_pbe_sha256_pkcs12_aes128_cbc = new DerObjectIdentifier(bc_pbe_sha256_pkcs12 + ".1.2");
		public static readonly DerObjectIdentifier bc_pbe_sha256_pkcs12_aes192_cbc = new DerObjectIdentifier(bc_pbe_sha256_pkcs12 + ".1.22");
		public static readonly DerObjectIdentifier bc_pbe_sha256_pkcs12_aes256_cbc = new DerObjectIdentifier(bc_pbe_sha256_pkcs12 + ".1.42");
	}
}