import React from 'react'
import useData from "../hooks/useData";
import { PostItem, LoaderSpinner, SideBar } from "../components/index";
import { useTitle } from '../hooks/useTitle'
import { toast } from "react-toastify";
export const Home = () => {

    //toast.error('err.message');

    useTitle("Home Page");

    const { data, loading, error } = useData(
        "/Posts/List"
    );
    return (
        <>

            <section>
                <div className="container">
                    <div className="row">
                        <div className="col-lg-12">
                            <div className="page-title">
                                <div className="row">
                                    <div className="col-lg-9">
                                        <h2><span>News and Stories</span></h2>

                                        <h4 className="subtitle text-muted">Aenean sollicitudin, lorem quis bibendum auctor, nisi elit consequat ipsum, nec sagittis sem nibh id elit. Proin gravida nibh vel velit auctor Aenean sollicitudin, adipisicing elit sed lorem quis bibendum auctor.</h4>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </section>


            <section className="margin-t-30">
                <div className="container">

                    <div className="row">
                        {/* <!--  Content--> */}
                        <div className="col-lg-8">

                            {loading && <LoaderSpinner />}
                            {data &&
                                data.map((post) => (
                                    <PostItem post={post} key={post.id} />
                                ))
                            }

                            {/* <!--  Pagination--> */}
                            <div className="row">
                                <div className="col-lg-12">
                                    <ul className="pagination">
                                        <li className="next"><a href="#"><i className="icofont-rounded-left"></i></a></li>
                                        <li className="active"><a href="#">1</a></li>
                                        <li><a href="#">2</a></li>
                                        <li><a href="#">3</a></li>
                                        <li><a href="#">4</a></li>
                                        <li><a href="#">5</a></li>
                                        <li className="prev"><a href="#"><i className="icofont-rounded-right"></i></a></li>
                                    </ul>
                                </div>
                            </div>
                            {/* <!--  Pagination end--> */}
                        </div>
                        {/* <!--  Content end--> */}


                        {/* <!--  Sidebar--> */}
                        <div className="col-lg-4">
                            <SideBar />
                        </div>
                        {/* <!--  Sidebar end--> */}
                    </div>

                </div> {/* <!--  end container --> */}
            </section>



        </>
    );
}