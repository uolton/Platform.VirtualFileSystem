#region License
/*
 * AbstractNodeDetails.cs
 * 
 * Copyright (c) 2004 Thong Nguyen (tum@veridicus.com)
 * 
 * This program is free software; you can redistribute it and/or modify it under
 * the terms of the GNU General Public License as published by the Free Software
 * Foundation; either version 2 of the License, or (at your option) any later
 * version.
 * 
 * This program is distributed in the hope that it will be useful, but WITHOUT
 * ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS
 * FOR A PARTICULAR PURPOSE. See the GNU General Public License for more
 * details.
 * 
 * You should have received a copy of the GNU General Public License along with
 * this program; if not, write to the Free Software Foundation, Inc., 59 Temple
 * Place, Suite 330, Boston, MA 02111-1307 USA
 * 
 * The license is packaged with the program archive in a file called LICENSE.TXT
 * 
 * You can also view a copy of the license online at:
 * http://www.opensource.org/licenses/gpl-license.php
 */
#endregion

using System;

namespace Platform.VirtualFileSystem.Providers
{
	/// <summary>
	/// This class provides a skeletal implementation of the <c>INodeDetails</c>interface to minimize the effort 
	/// required to implement the interface.
	/// <seealso cref="INodeDetails"/>
	/// </summary>
	public abstract class AbstractNodeDetails
		: INodeDetails
	{
		#region INodeDetails Members

		public virtual DateTime CreationTime
		{
			get
			{
				return DateTime.MinValue;
			}
			set
			{				
			}
		}

		public virtual DateTime LastAccessTime
		{
			get
			{
				return DateTime.MinValue;
			}
			set
			{				
			}
		}

		public virtual DateTime LastWriteTime
		{
			get
			{
				return DateTime.MinValue;
			}
			set
			{
			}
		}

		public virtual bool Exists
		{
			get
			{
				return false;
			}
		}

		public virtual void Refresh()
		{
		}

		#endregion
	}
}
