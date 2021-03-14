    void Update()
    {
        //Debug.Log("Mouse position: " + Input.mousePosition);

        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit)
            {
                Debug.Log("Raycast hit something!" + hit.collider.name);
            }
        }
        
    }