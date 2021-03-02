    private GameObject _pandora;
    private GameObject _pandoraChild;
    Animator anim;

    // Find works with object names, can be changed by tag
    //tst
    void Start()
    {
        _pandora = GameObject.Find("BoxOfPandora");
        _pandoraChild = _pandora.transform.Find("Box001").gameObject;
        anim = GetComponent<Animator>();
    }