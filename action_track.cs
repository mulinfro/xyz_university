

class Frame
{
    Transform trans;
    Actions action;
}

class Track
{
    // 帧开始的时间, 从0开始计算
    int startTimeIndex = 0;
    // 片段时间长度
    int trackTimeLength = 0;
    // 快进或者慢放速度
    float speed = 1;
    Vector<Frame> track = Vector<Frame>();
    
    Track(bindedObject selectedObj) {}

    addFrams(List[Transform] transform, List[Actions] actions) {}

    addFram(Transform transform, Actions actions) {}

    recordByControl(){}

    bindedWithBias(Track faTrack, Transform trans, RandomTransform rand){}

}

