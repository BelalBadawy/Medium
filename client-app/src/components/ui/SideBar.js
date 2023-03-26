import React from 'react'
import { PostCategories } from '../elements/PostCategories'
import { Tags } from '../elements/Tags'
import { PopularPosts } from '../elements/PopularPosts'
import { PostArchives } from '../elements/PostArchives'

export const SideBar = () => {
    return (
        <div className="sidebar">

            {/* <!--  Search widget--> */}
            <aside className="widget widget_search">
                <form>
                    <input className="form-control" type="search" placeholder="Search..." />
                    <button className="search-button" type="submit"><span className="icofont-search-1"></span></button>
                </form>
            </aside>

            {/* <!--  Categories widget--> */}
            <PostCategories />

            {/* <!--  Recent entries widget--> */}
            <PopularPosts />

            {/* <!--  Text widget--> */}
            <aside className="widget">
                <div className="widget-title">Text Widget</div>

                <p className="text-muted text-widget-des">Exercitation photo booth stumptown tote bag Banksy, elit small batch freegan sed. Craft beer elit seitan exercitation, photo booth et 8-bit kale chips proident chillwave deep v laborum. Aliquip veniam delectus, Marfa eiusmod Pinterest in do umami readymade swag. </p>

            </aside>

            {/* <!--  Archives widget--> */}
            <PostArchives />


            {/* <!--  Tags widget--> */}
            <Tags />

        </div>
    )
}
