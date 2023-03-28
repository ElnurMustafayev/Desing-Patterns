using ChainOfResponsibility.Handlers;

Handler1 hander1 = new Handler1();
Handler2 hander2 = new Handler2();
Handler3 hander3 = new Handler3();

hander1
    .SetNext(hander2)
    .SetNext(hander3)
    .SetNext(new Handler1())
    .SetNext(new Handler2());

hander1.Handle("something for proceed");