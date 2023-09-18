using System;
namespace actuariallearning.Courses.Models
{

    public enum Permissions
    {
        //permission for the author - add to this list if there are any other permissions
        create_author,
        delete_author,
        get_author,
        update_author,
        get_authors,
        delete_authors,
        update_authors,

        //permissions for students
        create_student,
        delete_student,
        get_student,
        update_student,
        update_students,
        get_students,
        delete_students,

        //permission for comments
        create_comment,
        delete_comment,
        get_comment,
        update_comment,
        delete_comments,
        get_comments,
        update_comments,


        //permission for videos
        create_video,
        delete_video,
        update_video,
        get_video,
        delete_videos,
        get_videos

    }
}
