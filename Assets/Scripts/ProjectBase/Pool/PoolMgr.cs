using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Pool;
using static UnityEngine.RuleTile.TilingRuleOutput;


/// <summary>
/// 缓存池模块
/// 1.Dictionary List 2.GameObject 和 Resources 两个公共类中的 API 
/// </summary>
public class PoolMgr<T> : SingletonMono<PoolMgr<T>> where T : MonoBehaviour
{
    [Header("Objects")]
    [SerializeField] private T objectPoolPrefab;
    private ObjectPool<T> objectPool;

    // 初始化对象池
    protected override  void Awake()
    {
        base.Awake();
        objectPool = new ObjectPool<T>(
            CreateFunction,
            ActionOnGet,
            ActionOnRelease,
            ActionOnDestroy
        );
    }
    #region 池化
    // 创建新对象
    private T CreateFunction()
    {
        return Instantiate(objectPoolPrefab, transform);
    }

    // 激活对象
    private void ActionOnGet(T obj)
    {
        obj.gameObject.SetActive(true);
    }

    // 归还对象时，失活对象
    private void ActionOnRelease(T obj)
    {
        obj.gameObject.SetActive(false);
    }

    // 销毁对象
    private void ActionOnDestroy(T obj)
    {
        Destroy(obj.gameObject);
    }
    #endregion


    // 获取对象
    public T Get()
    {
        return objectPool.Get();
    }

    // 归还对象
    public void Release(T obj)
    {
        objectPool.Release(obj);
    }

    // 可选：清理池中对象
    public void ClearPool()
    {
        objectPool.Clear();
    }

    // 可在子类中重写方法，来实现具体的对象创建、获取、归还行为
    protected virtual void OnDestroy()
    {
        ClearPool();
    }
}
