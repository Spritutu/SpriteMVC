﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_U2D_SpriteAtlasWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.U2D.SpriteAtlas), typeof(UnityEngine.Object));
		L.RegFunction("CanBindTo", CanBindTo);
		L.RegFunction("GetSprite", GetSprite);
		L.RegFunction("GetSprites", GetSprites);
		L.RegFunction("New", _CreateUnityEngine_U2D_SpriteAtlas);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("isVariant", get_isVariant, null);
		L.RegVar("tag", get_tag, null);
		L.RegVar("spriteCount", get_spriteCount, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_U2D_SpriteAtlas(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				UnityEngine.U2D.SpriteAtlas obj = new UnityEngine.U2D.SpriteAtlas();
				ToLua.Push(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: UnityEngine.U2D.SpriteAtlas.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CanBindTo(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.U2D.SpriteAtlas obj = (UnityEngine.U2D.SpriteAtlas)ToLua.CheckObject<UnityEngine.U2D.SpriteAtlas>(L, 1);
			UnityEngine.Sprite arg0 = (UnityEngine.Sprite)ToLua.CheckObject(L, 2, typeof(UnityEngine.Sprite));
			bool o = obj.CanBindTo(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetSprite(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.U2D.SpriteAtlas obj = (UnityEngine.U2D.SpriteAtlas)ToLua.CheckObject<UnityEngine.U2D.SpriteAtlas>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			UnityEngine.Sprite o = obj.GetSprite(arg0);
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetSprites(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				UnityEngine.U2D.SpriteAtlas obj = (UnityEngine.U2D.SpriteAtlas)ToLua.CheckObject<UnityEngine.U2D.SpriteAtlas>(L, 1);
				UnityEngine.Sprite[] arg0 = ToLua.CheckObjectArray<UnityEngine.Sprite>(L, 2);
				int o = obj.GetSprites(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 3)
			{
				UnityEngine.U2D.SpriteAtlas obj = (UnityEngine.U2D.SpriteAtlas)ToLua.CheckObject<UnityEngine.U2D.SpriteAtlas>(L, 1);
				UnityEngine.Sprite[] arg0 = ToLua.CheckObjectArray<UnityEngine.Sprite>(L, 2);
				string arg1 = ToLua.CheckString(L, 3);
				int o = obj.GetSprites(arg0, arg1);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.U2D.SpriteAtlas.GetSprites");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isVariant(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.U2D.SpriteAtlas obj = (UnityEngine.U2D.SpriteAtlas)o;
			bool ret = obj.isVariant;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index isVariant on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_tag(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.U2D.SpriteAtlas obj = (UnityEngine.U2D.SpriteAtlas)o;
			string ret = obj.tag;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index tag on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_spriteCount(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.U2D.SpriteAtlas obj = (UnityEngine.U2D.SpriteAtlas)o;
			int ret = obj.spriteCount;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index spriteCount on a nil value");
		}
	}
}

